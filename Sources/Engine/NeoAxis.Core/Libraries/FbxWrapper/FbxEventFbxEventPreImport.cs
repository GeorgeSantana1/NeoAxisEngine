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

public class FbxEventFbxEventPreImport : FbxEventBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxEventFbxEventPreImport(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxEventFbxEventPreImport_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventFbxEventPreImport obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventFbxEventPreImport() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxEventFbxEventPreImport(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static void ForceTypeId(int pTypeId) {
    FbxWrapperNativePINVOKE.FbxEventFbxEventPreImport_ForceTypeId(pTypeId);
  }

  public override int GetTypeId() {
    int ret = FbxWrapperNativePINVOKE.FbxEventFbxEventPreImport_GetTypeId(swigCPtr);
    return ret;
  }

  public static int GetStaticTypeId() {
    int ret = FbxWrapperNativePINVOKE.FbxEventFbxEventPreImport_GetStaticTypeId();
    return ret;
  }

}

}
