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

public class FbxLayerElement : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxLayerElement(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static SWIGTYPE_p_p_char sTextureNames {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_sTextureNames_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char sTextureUVNames {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_sTextureUVNames_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char sNonTextureNames {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_sNonTextureNames_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public static FbxDataType sTextureDataTypes {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_sTextureDataTypes_get();
      FbxDataType ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDataType(cPtr, false);
      return ret;
    } 
  }

  public static SWIGTYPE_p_p_char sTextureChannelNames {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_sTextureChannelNames_get();
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public void SetMappingMode(FbxLayerElement.EMappingMode pMappingMode) {
    FbxWrapperNativePINVOKE.FbxLayerElement_SetMappingMode(swigCPtr, (int)pMappingMode);
  }

  public void SetReferenceMode(FbxLayerElement.EReferenceMode pReferenceMode) {
    FbxWrapperNativePINVOKE.FbxLayerElement_SetReferenceMode(swigCPtr, (int)pReferenceMode);
  }

  public FbxLayerElement.EMappingMode GetMappingMode() {
    FbxLayerElement.EMappingMode ret = (FbxLayerElement.EMappingMode)FbxWrapperNativePINVOKE.FbxLayerElement_GetMappingMode(swigCPtr);
    return ret;
  }

  public FbxLayerElement.EReferenceMode GetReferenceMode() {
    FbxLayerElement.EReferenceMode ret = (FbxLayerElement.EReferenceMode)FbxWrapperNativePINVOKE.FbxLayerElement_GetReferenceMode(swigCPtr);
    return ret;
  }

  public void SetName(string pName) {
    FbxWrapperNativePINVOKE.FbxLayerElement_SetName(swigCPtr, pName);
  }

  public string GetName() {
    string ret = FbxWrapperNativePINVOKE.FbxLayerElement_GetName(swigCPtr);
    return ret;
  }

  public bool eq(FbxLayerElement pOther) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElement_eq(swigCPtr, FbxLayerElement.getCPtr(pOther));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElement assign(FbxLayerElement pOther) {
    FbxLayerElement ret = new FbxLayerElement(FbxWrapperNativePINVOKE.FbxLayerElement_assign(swigCPtr, FbxLayerElement.getCPtr(pOther)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Destroy() {
    FbxWrapperNativePINVOKE.FbxLayerElement_Destroy(swigCPtr);
  }

  public virtual bool Clear() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElement_Clear(swigCPtr);
    return ret;
  }

  public void SetType(FbxDataType pType) {
    FbxWrapperNativePINVOKE.FbxLayerElement_SetType(swigCPtr, FbxDataType.getCPtr(pType));
  }

  public FbxLayerContainer GetOwner() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElement_GetOwner(swigCPtr);
    FbxLayerContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerContainer(cPtr, false);
    return ret;
  }

  public void IncRefCount() {
    FbxWrapperNativePINVOKE.FbxLayerElement_IncRefCount(swigCPtr);
  }

  public int DecRefCount() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElement_DecRefCount(swigCPtr);
    return ret;
  }

  public virtual int MemorySize() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElement_MemorySize(swigCPtr);
    return ret;
  }

  public virtual bool ContentWriteTo(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElement_ContentWriteTo(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool ContentReadFrom(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElement_ContentReadFrom(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EType {
    eUnknown,
    eNormal,
    eBiNormal,
    eTangent,
    eMaterial,
    ePolygonGroup,
    eUV,
    eVertexColor,
    eSmoothing,
    eVertexCrease,
    eEdgeCrease,
    eHole,
    eUserData,
    eVisibility,
    eTextureDiffuse,
    eTextureDiffuseFactor,
    eTextureEmissive,
    eTextureEmissiveFactor,
    eTextureAmbient,
    eTextureAmbientFactor,
    eTextureSpecular,
    eTextureSpecularFactor,
    eTextureShininess,
    eTextureNormalMap,
    eTextureBump,
    eTextureTransparency,
    eTextureTransparencyFactor,
    eTextureReflection,
    eTextureReflectionFactor,
    eTextureDisplacement,
    eTextureDisplacementVector,
    eTypeCount
  }

  public static readonly int sTypeTextureStartIndex = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeTextureStartIndex_get();
  public static readonly int sTypeTextureEndIndex = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeTextureEndIndex_get();
  public static readonly int sTypeTextureCount = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeTextureCount_get();
  public static readonly int sTypeNonTextureStartIndex = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeNonTextureStartIndex_get();
  public static readonly int sTypeNonTextureEndIndex = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeNonTextureEndIndex_get();
  public static readonly int sTypeNonTextureCount = FbxWrapperNativePINVOKE.FbxLayerElement_sTypeNonTextureCount_get();
  public enum EMappingMode {
    eNone,
    eByControlPoint,
    eByPolygonVertex,
    eByPolygon,
    eByEdge,
    eAllSame
  }

  public enum EReferenceMode {
    eDirect,
    eIndex,
    eIndexToDirect
  }

}

}
