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

public class FbxAnimCurveKey_Impl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveKey_Impl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveKey_Impl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveKey_Impl() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxAnimCurveKey_Impl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual FbxAnimCurveKey_Impl assign(FbxAnimCurveKey_Impl pFKey) {
    FbxAnimCurveKey_Impl ret = new FbxAnimCurveKey_Impl(FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_assign(swigCPtr, FbxAnimCurveKey_Impl.getCPtr(pFKey)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Set(FbxTime pTime, float pValue) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_Set(swigCPtr, FbxTime.getCPtr(pTime), pValue);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0, float pData1, float pData2) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0, pData1, pData2);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0, float pData1) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0, pData1);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue, float pData0) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_2(swigCPtr, FbxTime.getCPtr(pTime), pValue, pData0);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetTCB(FbxTime pTime, float pValue) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTCB__SWIG_3(swigCPtr, FbxTime.getCPtr(pTime), pValue);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float GetValue() {
    float ret = FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetValue(swigCPtr);
    return ret;
  }

  public virtual void SetValue(float pValue) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetValue(swigCPtr, pValue);
  }

  public virtual FbxAnimCurveDef.EInterpolationType GetInterpolation() {
    FbxAnimCurveDef.EInterpolationType ret = (FbxAnimCurveDef.EInterpolationType)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetInterpolation(swigCPtr);
    return ret;
  }

  public virtual void SetInterpolation(FbxAnimCurveDef.EInterpolationType pInterpolation) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetInterpolation(swigCPtr, (int)pInterpolation);
  }

  public virtual FbxAnimCurveDef.ETangentMode GetTangentMode(bool pIncludeOverrides) {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetTangentMode__SWIG_0(swigCPtr, pIncludeOverrides);
    return ret;
  }

  public virtual FbxAnimCurveDef.ETangentMode GetTangentMode() {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetTangentMode__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual void SetTangentMode(FbxAnimCurveDef.ETangentMode pTangentMode) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentMode(swigCPtr, (int)pTangentMode);
  }

  public virtual FbxAnimCurveDef.EWeightedMode GetTangentWeightMode() {
    FbxAnimCurveDef.EWeightedMode ret = (FbxAnimCurveDef.EWeightedMode)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetTangentWeightMode(swigCPtr);
    return ret;
  }

  public virtual void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode, FbxAnimCurveDef.EWeightedMode pMask) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightMode__SWIG_0(swigCPtr, (int)pTangentWeightMode, (int)pMask);
  }

  public virtual void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightMode__SWIG_1(swigCPtr, (int)pTangentWeightMode);
  }

  public virtual void SetTangentWeightAndAdjustTangent(FbxAnimCurveDef.EDataIndex pIndex, double pWeight) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentWeightAndAdjustTangent(swigCPtr, (int)pIndex, pWeight);
  }

  public virtual FbxAnimCurveDef.EVelocityMode GetTangentVelocityMode() {
    FbxAnimCurveDef.EVelocityMode ret = (FbxAnimCurveDef.EVelocityMode)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetTangentVelocityMode(swigCPtr);
    return ret;
  }

  public virtual void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode, FbxAnimCurveDef.EVelocityMode pMask) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentVelocityMode__SWIG_0(swigCPtr, (int)pTangentVelocityMode, (int)pMask);
  }

  public virtual void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentVelocityMode__SWIG_1(swigCPtr, (int)pTangentVelocityMode);
  }

  public virtual FbxAnimCurveDef.EConstantMode GetConstantMode() {
    FbxAnimCurveDef.EConstantMode ret = (FbxAnimCurveDef.EConstantMode)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetConstantMode(swigCPtr);
    return ret;
  }

  public virtual void SetConstantMode(FbxAnimCurveDef.EConstantMode pMode) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetConstantMode(swigCPtr, (int)pMode);
  }

  public virtual float GetDataFloat(FbxAnimCurveDef.EDataIndex pIndex) {
    float ret = FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetDataFloat(swigCPtr, (int)pIndex);
    return ret;
  }

  public virtual void SetDataFloat(FbxAnimCurveDef.EDataIndex pIndex, float pValue) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetDataFloat(swigCPtr, (int)pIndex, pValue);
  }

  public virtual void SetTangentVisibility(FbxAnimCurveDef.ETangentVisibility pVisibility) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetTangentVisibility(swigCPtr, (int)pVisibility);
  }

  public virtual FbxAnimCurveDef.ETangentVisibility GetTangentVisibility() {
    FbxAnimCurveDef.ETangentVisibility ret = (FbxAnimCurveDef.ETangentVisibility)FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetTangentVisibility(swigCPtr);
    return ret;
  }

  public virtual void SetBreak(bool pVal) {
    FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_SetBreak(swigCPtr, pVal);
  }

  public virtual bool GetBreak() {
    bool ret = FbxWrapperNativePINVOKE.FbxAnimCurveKey_Impl_GetBreak(swigCPtr);
    return ret;
  }

}

}
