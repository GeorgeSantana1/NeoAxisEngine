//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxEventPopulateSystemLibrary : FbxEventFbxEventPopulateSystemLibrary {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxEventPopulateSystemLibrary(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxEventPopulateSystemLibrary_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventPopulateSystemLibrary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventPopulateSystemLibrary() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxEventPopulateSystemLibrary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string GetEventName() {
    string ret = FbxWrapperNativePINVOKE.FbxEventPopulateSystemLibrary_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventPopulateSystemLibrary(FbxLibrary pLibrary) : this(FbxWrapperNativePINVOKE.new_FbxEventPopulateSystemLibrary(FbxLibrary.getCPtr(pLibrary)), true) {
  }

  public FbxLibrary GetLibrary() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEventPopulateSystemLibrary_GetLibrary(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

}

}
