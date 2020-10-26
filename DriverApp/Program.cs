using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using TS3D.Exchange.Direct;

namespace DriverApp
{
    using InstancePath = List<IntPtr>;
    using InstancePathArray = List<List<IntPtr> >;
    class Program
    {
        
        static string GetName( IntPtr ntt )
        {
            var root_base_data = new A3DRootBaseDataWrapper(ntt) ;
            return root_base_data.m_pcName;
        }

        static IntPtr GetPartDefinition( IntPtr po ) {
            if( po == IntPtr.Zero ) {
                return IntPtr.Zero;
            }

            var d = new A3DAsmProductOccurrenceDataWrapper(po);
            return d.m_pPart != IntPtr.Zero ? d.m_pPart : GetPartDefinition( d.m_pPrototype );
        }

        static InstancePathArray RecursivelyPrintPONames( IntPtr po, InstancePath owners )
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

            var po_data = new A3DAsmProductOccurrenceDataWrapper( po );
            for( var idx = 0; idx < po_data.m_uiPOccurrencesSize; ++idx)
            {
                var child_po = Marshal.ReadIntPtr(po_data.m_ppPOccurrences, idx * Marshal.SizeOf( typeof( IntPtr ) ) );
                var child_paths = RecursivelyPrintPONames(child_po, current_owners);
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
            TS3D.Exchange.Library.SetExchangeLibraryFolder("/opt/local/ts3d/HOOPS_Exchange_2020_SP2_U2/bin/osx64");
            if(A3DStatus.A3D_SUCCESS != TS3D.Exchange.Direct.API.A3DLicPutUnifiedLicense(HOOPS_LICENSE.KEY) ) {
                Console.WriteLine("Unable to unlock HOOPS Exchange." );
            }

            int major_version, minor_version;
            TS3D.Exchange.Direct.API.A3DDllGetVersion( out major_version, out minor_version );
            TS3D.Exchange.Direct.API.A3DDllInitialize( major_version, minor_version );

            TS3D.Exchange.Direct.API.A3DDllSetCallbacksReport( 
                Marshal.GetFunctionPointerForDelegate( new TS3D.Exchange.Direct.API.A3DCallbackReportMessage( MessageCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new TS3D.Exchange.Direct.API.A3DCallbackReportMessage( WarningCallback ) ),
                Marshal.GetFunctionPointerForDelegate( new TS3D.Exchange.Direct.API.A3DCallbackReportMessage( ErrorCallback ) ) );

            
            Test.PerformStructSizeTests();

            A3DRWParamsLoadData load_params;
            API.Initialize(out load_params);
            IntPtr model_file;
            var status = API.A3DAsmModelFileLoadFromFile("/opt/local/ts3d/HOOPS_Exchange_2020_SP2_U2/samples/data/catiaV5/CV5_Micro_engine/_micro engine.CATProduct", ref load_params, out model_file ) ;
            if(A3DStatus.A3D_SUCCESS != status) {
                Console.WriteLine( "Failed to load input file." );
            }

            var model_file_data = new A3DAsmModelFileDataWrapper( model_file );
            InstancePath owners = new InstancePath();
            owners.Add( model_file );
            var po = Marshal.ReadIntPtr(model_file_data.m_ppPOccurrences);
            var result = RecursivelyPrintPONames(po, owners);
            Console.WriteLine( "There are " + result.Count + " part instances." );
        }
    }
}
