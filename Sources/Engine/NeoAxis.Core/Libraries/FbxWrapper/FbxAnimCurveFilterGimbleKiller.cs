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

public class FbxAnimCurveFilterGimbleKiller : FbxAnimCurveFilter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxAnimCurveFilterGimbleKiller(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveFilterGimbleKiller obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveFilterGimbleKiller() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxAnimCurveFilterGimbleKiller(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxAnimCurveFilterGimbleKiller() : this(FbxWrapperNativePINVOKE.new_FbxAnimCurveFilterGimbleKiller(), true) {
  }

  public override string GetName() {
    string ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_GetName(swigCPtr);
    return ret;
  }

  public override bool NeedApply(FbxAnimStack arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_0(swigCPtr, FbxAnimStack.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(FbxAnimStack arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_1(swigCPtr, FbxAnimStack.getCPtr(arg0));
    return ret;
  }

  public override bool NeedApply(FbxObject arg0, FbxAnimStack arg1, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_2(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(FbxObject arg0, FbxAnimStack arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_3(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1));
    return ret;
  }

  public override bool NeedApply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_4(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_5(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_6(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool NeedApply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_7(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public override bool NeedApply(FbxAnimCurve arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_8(swigCPtr, FbxAnimCurve.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool NeedApply(FbxAnimCurve arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_NeedApply__SWIG_9(swigCPtr, FbxAnimCurve.getCPtr(arg0));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimStack arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_0(swigCPtr, FbxAnimStack.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(FbxAnimStack arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_1(swigCPtr, FbxAnimStack.getCPtr(arg0));
    return ret;
  }

  public override bool Apply(FbxObject arg0, FbxAnimStack arg1, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_2(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(FbxObject arg0, FbxAnimStack arg1) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_3(swigCPtr, FbxObject.getCPtr(arg0), FbxAnimStack.getCPtr(arg1));
    return ret;
  }

  public override bool Apply(FbxAnimCurveNode pCurveNode, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_4(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimCurveNode pCurveNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_5(swigCPtr, FbxAnimCurveNode.getCPtr(pCurveNode));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_6(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public override bool Apply(SWIGTYPE_p_p_FbxAnimCurve pCurve, int pCount) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_7(swigCPtr, SWIGTYPE_p_p_FbxAnimCurve.getCPtr(pCurve), pCount);
    return ret;
  }

  public override bool Apply(FbxAnimCurve arg0, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_8(swigCPtr, FbxAnimCurve.getCPtr(arg0), FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool Apply(FbxAnimCurve arg0) {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Apply__SWIG_9(swigCPtr, FbxAnimCurve.getCPtr(arg0));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Reset() {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_Reset(swigCPtr);
  }

  public bool GetApplyKeySyncFilter() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_GetApplyKeySyncFilter(swigCPtr);
    return ret;
  }

  public void SetApplyKeySyncFilter(bool pFlag) {
    FbxWrapperNativePINVOKE.FbxAnimCurveFilterGimbleKiller_SetApplyKeySyncFilter(swigCPtr, pFlag);
  }

}

}
