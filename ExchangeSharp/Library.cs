
using System;
using System.Runtime.InteropServices;


namespace TS3D.Exchange
{
    public class Library
    {
        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetAPILookupFunction();
        
        public delegate IntPtr PFA3DGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string fcn_spelling, UInt32 apI_flags);
        public static PFA3DGetProcAddress A3DGetProcAddress = Marshal.GetDelegateForFunctionPointer<PFA3DGetProcAddress>(GetAPILookupFunction());

        [DllImport("Exchange.layer", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static public extern void SetExchangeLibraryFolder([MarshalAs(UnmanagedType.LPStr)] string folder );
    }
}
