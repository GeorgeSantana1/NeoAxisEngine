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

public class FbxLoadingStrategy : FbxPluginContainer {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLoadingStrategy(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLoadingStrategy_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLoadingStrategy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLoadingStrategy() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxLoadingStrategy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxLoadingStrategy.EState Load(FbxPluginData pData) {
    FbxLoadingStrategy.EState ret = (FbxLoadingStrategy.EState)FbxWrapperNativePINVOKE.FbxLoadingStrategy_Load(swigCPtr, FbxPluginData.getCPtr(pData));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Unload() {
    FbxWrapperNativePINVOKE.FbxLoadingStrategy_Unload(swigCPtr);
  }

  public enum EState {
    eAllLoaded,
    eNoneLoaded,
    eAllFailed,
    eSomeFailed
  }

}

}
