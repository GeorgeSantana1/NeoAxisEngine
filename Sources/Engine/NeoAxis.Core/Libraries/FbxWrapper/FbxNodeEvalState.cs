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

public class FbxNodeEvalState : FbxEvalState {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxNodeEvalState(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxNodeEvalState_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxNodeEvalState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxNodeEvalState() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxNodeEvalState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxNodeEvalState(FbxNode pNode) : this(FbxWrapperNativePINVOKE.new_FbxNodeEvalState(FbxNode.getCPtr(pNode)), true) {
  }

  public FbxVector4 mLT {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mLT_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mLT_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mLR {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mLR_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mLR_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxVector4 mLS {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mLS_set(swigCPtr, FbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mLS_get(swigCPtr);
      FbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxVector4(cPtr, false);
      return ret;
    } 
  }

  public FbxAMatrix mLX {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mLX_set(swigCPtr, FbxAMatrix.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mLX_get(swigCPtr);
      FbxAMatrix ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAMatrix(cPtr, false);
      return ret;
    } 
  }

  public FbxAMatrix mGX {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mGX_set(swigCPtr, FbxAMatrix.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mGX_get(swigCPtr);
      FbxAMatrix ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAMatrix(cPtr, false);
      return ret;
    } 
  }

  public FbxTransform mTransform {
    set {
      FbxWrapperNativePINVOKE.FbxNodeEvalState_mTransform_set(swigCPtr, FbxTransform.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxNodeEvalState_mTransform_get(swigCPtr);
      FbxTransform ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTransform(cPtr, false);
      return ret;
    } 
  }

}

}
