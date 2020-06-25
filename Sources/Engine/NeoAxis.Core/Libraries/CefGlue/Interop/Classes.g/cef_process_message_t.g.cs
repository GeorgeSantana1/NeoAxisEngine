//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_process_message_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_valid;
        internal IntPtr _is_read_only;
        internal IntPtr _copy;
        internal IntPtr _get_name;
        internal IntPtr _get_argument_list;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_process_message_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_process_message_t* create(cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_valid_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_read_only_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_process_message_t* copy_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_name_delegate(cef_process_message_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_list_value_t* get_argument_list_delegate(cef_process_message_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_process_message_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_process_message_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_process_message_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsValid
        private static IntPtr _p3;
        private static is_valid_delegate _d3;
        
        public static int is_valid(cef_process_message_t* self)
        {
            is_valid_delegate d;
            var p = self->_is_valid;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_valid_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_valid_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // IsReadOnly
        private static IntPtr _p4;
        private static is_read_only_delegate _d4;
        
        public static int is_read_only(cef_process_message_t* self)
        {
            is_read_only_delegate d;
            var p = self->_is_read_only;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // Copy
        private static IntPtr _p5;
        private static copy_delegate _d5;
        
        public static cef_process_message_t* copy(cef_process_message_t* self)
        {
            copy_delegate d;
            var p = self->_copy;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (copy_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(copy_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetName
        private static IntPtr _p6;
        private static get_name_delegate _d6;
        
        public static cef_string_userfree* get_name(cef_process_message_t* self)
        {
            get_name_delegate d;
            var p = self->_get_name;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_name_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetArgumentList
        private static IntPtr _p7;
        private static get_argument_list_delegate _d7;
        
        public static cef_list_value_t* get_argument_list(cef_process_message_t* self)
        {
            get_argument_list_delegate d;
            var p = self->_get_argument_list;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_argument_list_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_argument_list_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
    }
}
