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

public class FbxConstraintScale : FbxConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxConstraintScale(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxConstraintScale_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxConstraintScale obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxConstraintScale_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxConstraintScale Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxConstraintScale ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintScale(cPtr, false);
    return ret;
  }

  public new static FbxConstraintScale Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxConstraintScale ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintScale(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectX {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_AffectX_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_AffectX_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectY {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_AffectY_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_AffectY_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t AffectZ {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_AffectZ_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_AffectZ_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 Scaling {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_Scaling_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_Scaling_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ConstraintSources {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_ConstraintSources_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_ConstraintSources_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ConstrainedObject {
    set {
      FbxWrapperNativePINVOKE.FbxConstraintScale_ConstrainedObject_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_ConstrainedObject_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxObject_p_t(cPtr, false);
      return ret;
    } 
  }

  public void AddConstraintSource(FbxObject pObject, double pWeight) {
    FbxWrapperNativePINVOKE.FbxConstraintScale_AddConstraintSource__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pWeight);
  }

  public void AddConstraintSource(FbxObject pObject) {
    FbxWrapperNativePINVOKE.FbxConstraintScale_AddConstraintSource__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public override int GetConstraintSourceCount() {
    int ret = FbxWrapperNativePINVOKE.FbxConstraintScale_GetConstraintSourceCount(swigCPtr);
    return ret;
  }

  public override FbxObject GetConstraintSource(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_GetConstraintSource(swigCPtr, pIndex);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public void SetConstrainedObject(FbxObject pObject) {
    FbxWrapperNativePINVOKE.FbxConstraintScale_SetConstrainedObject(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public override FbxObject GetConstrainedObject() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxConstraintScale_GetConstrainedObject(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

}

}
