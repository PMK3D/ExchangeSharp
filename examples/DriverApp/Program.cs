using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using TS3D.Exchange;
using TS3D.Exchange.Direct;

namespace DriverApp
{
    using InstancePath = List<IntPtr>;
    using InstancePathArray = List<List<IntPtr> >;
    class Program
    {   
        static IntPtr GetPartDefinition( IntPtr po ) {
            if( po == IntPtr.Zero ) {
                return IntPtr.Zero;
            }

            var d = new A3DAsmProductOccurrenceWrapper(po);
            return d.m_pPart != IntPtr.Zero ? d.m_pPart : GetPartDefinition( d.m_pPrototype );
        }

        static InstancePathArray GetAllPartInstances( IntPtr po, InstancePath owners )
        {
            InstancePathArray result = new InstancePathArray();
            var current_owners = new InstancePath( owners );
            current_owners.Add( po );

            var part = GetPartDefinition( po );
            if( IntPtr.Zero != part ) {
                current_owners.Add( part );
                result.Add( current_owners );
                return result;
            }

            var po_data = new A3DAsmProductOccurrenceWrapper( po );
            for( var idx = 0; idx < po_data.m_uiPOccurrencesSize; ++idx)
            {
                var child_po = Marshal.ReadIntPtr(po_data.m_ppPOccurrences, idx * Marshal.SizeOf( typeof( IntPtr ) ) );
                var child_paths = GetAllPartInstances(child_po, current_owners);
                result.AddRange( child_paths );
            }

            return result;
        }

        public static int MessageCallback( string message ) {
            Console.Write( "[INFO] " + message );
            return 0;
        }

        public static int WarningCallback( string message ) {
            Console.Write( "[WARN] " + message );
            return 0;
        }
        public static int ErrorCallback( string message ) {
            Console.Write( "[ERR] " + message );
            return 0;
        }
        static void Main(string[] args)
        {   
            string exchange_folder = "";
            string input_file = null;
            for(var arg = 0; arg < args.Length; ++arg ) {
                if( arg < args.Length-1 ) {
                    if( args[arg] == "--exchange" ) {
                        exchange_folder = args[++arg];
                        continue;
                    }
                }
                input_file = args[arg];
            }

            if( null == input_file ) {
                Console.WriteLine("Please provide an input file as an argument." );
                return;
            }

            try {
                Library.SetExchangeLibraryFolder(exchange_folder);
            } catch(System.TypeInitializationException) {
                Console.WriteLine("Unable to load \"Exchange.layer\".");
                Console.WriteLine("Please be sure the folder containing \"Exchange.layer\" is included in");
                Console.Write("the environment variable \"");
                if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform( OSPlatform.Windows ) ) {
                    Console.Write("PATH");
                } else if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ) {
                    Console.Write("LD_LIBRARY_PATH");
                } else if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ) {
                    Console.Write("DYLD_LIBRARY_PATH");
                }
                Console.WriteLine("\",");
                Console.WriteLine("or it is located in the current working directory.");
                return;
            }

            try {
                if(A3DStatus.A3D_SUCCESS != API.A3DLicPutUnifiedLicense(HOOPS_LICENSE.KEY) ) {
                    Console.WriteLine("Unable to unlock HOOPS Exchange." );
                    return;
                }
            } catch(System.TypeInitializationException) {
                Console.WriteLine("Unable to load Exchange.");
                Console.WriteLine("Please specify the Exchange bin folder using the command line option '--exchange'.");
                Console.Write("Alternatively, set the environment variable \"");
                if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform( OSPlatform.Windows ) ) {
                    Console.Write("PATH");
                } else if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ) {
                    Console.Write("LD_LIBRARY_PATH");
                } else if( System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ) {
                    Console.Write("DYLD_LIBRARY_PATH");
                }
                Console.WriteLine("\",");
                Console.WriteLine("to include the Exchange bin folder.");
                return;
            }

            int major_version, minor_version;
            API.A3DDllGetVersion( out major_version, out minor_version );
            API.A3DDllInitialize( major_version, minor_version );

            API.A3DDllSetCallbacksReport( 
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( MessageCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( WarningCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new API.A3DCallbackReportMessage( ErrorCallback ) ) );

            
            Test.PerformStructSizeTests();

            A3DRWParamsLoadData load_params;
            API.Initialize(out load_params);
            IntPtr model_file;
            var status = API.A3DAsmModelFileLoadFromFile(input_file, ref load_params, out model_file ) ;
            if(A3DStatus.A3D_SUCCESS != status) {
                Console.WriteLine( "Failed to load input file." );
            }

            var model_file_data = new A3DAsmModelFileWrapper( model_file );
            InstancePath owners = new InstancePath();
            owners.Add( model_file );
            var po = Marshal.ReadIntPtr(model_file_data.m_ppPOccurrences);
            var result = GetAllPartInstances(po, owners);
            Console.WriteLine( "There are " + result.Count + " part instances." );
        }
    }
}
