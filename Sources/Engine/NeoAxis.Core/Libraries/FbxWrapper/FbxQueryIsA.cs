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

public class FbxQueryIsA : FbxQuery {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxQueryIsA(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxQueryIsA_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxQueryIsA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxQueryIsA() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxQueryIsA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxQueryIsA Create(FbxClassId pClassId) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxQueryIsA_Create(FbxClassId.getCPtr(pClassId));
    FbxQueryIsA ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxQueryIsA(cPtr, false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetUniqueId() {
    int ret = FbxWrapperNativePINVOKE.FbxQueryIsA_GetUniqueId(swigCPtr);
    return ret;
  }

  public override bool IsValid(FbxProperty pProperty) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryIsA_IsValid(swigCPtr, FbxProperty.getCPtr(pProperty));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsEqual(FbxQuery pOtherQuery) {
    bool ret = FbxWrapperNativePINVOKE.FbxQueryIsA_IsEqual(swigCPtr, FbxQuery.getCPtr(pOtherQuery));
    return ret;
  }

}

}
