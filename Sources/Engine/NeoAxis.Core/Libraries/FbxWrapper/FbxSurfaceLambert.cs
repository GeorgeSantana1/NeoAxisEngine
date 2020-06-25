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

public class FbxSurfaceLambert : FbxSurfaceMaterial {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSurfaceLambert(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxSurfaceLambert_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSurfaceLambert obj) {
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
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxSurfaceLambert_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSurfaceLambert Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public new static FbxSurfaceLambert Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public FbxPropertyTFbxDouble3 Emissive {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_Emissive_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Emissive_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble EmissiveFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_EmissiveFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_EmissiveFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 Ambient {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_Ambient_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Ambient_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble AmbientFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_AmbientFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_AmbientFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 Diffuse {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_Diffuse_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Diffuse_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble DiffuseFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_DiffuseFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_DiffuseFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 NormalMap {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_NormalMap_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_NormalMap_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 Bump {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_Bump_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Bump_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble BumpFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_BumpFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_BumpFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 TransparentColor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_TransparentColor_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_TransparentColor_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble TransparencyFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_TransparencyFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_TransparencyFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 DisplacementColor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_DisplacementColor_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_DisplacementColor_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble DisplacementFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_DisplacementFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_DisplacementFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble3 VectorDisplacementColor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_VectorDisplacementColor_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_VectorDisplacementColor_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble VectorDisplacementFactor {
    set {
      FbxWrapperNativePINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public static FbxDouble3 sEmissiveDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sEmissiveDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sEmissiveFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sEmissiveFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sAmbientDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sAmbientDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sAmbientFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sAmbientFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sDiffuseDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sDiffuseDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sDiffuseFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sDiffuseFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sBumpDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sBumpDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static FbxDouble3 sNormalMapDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sNormalMapDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sBumpFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sBumpFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sTransparentDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sTransparentDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sTransparencyFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sTransparencyFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sDisplacementDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sDisplacementDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sDisplacementFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sDisplacementFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sVectorDisplacementDefault {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sVectorDisplacementDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sVectorDisplacementFactorDefault {
    get {
      double ret = FbxWrapperNativePINVOKE.FbxSurfaceLambert_sVectorDisplacementFactorDefault_get();
      return ret;
    } 
  }

  public static FbxSurfaceLambert Cast(FbxObject arg0) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxSurfaceLambert_Cast(FbxObject.getCPtr(arg0));
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

}

}
