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

public class FbxLayerElementTemplateFbxVector2 : FbxLayerElement {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementTemplateFbxVector2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementTemplateFbxVector2 obj) {
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

  public FbxLayerElementArrayTemplateFbxVector2 GetDirectArray() {
    FbxLayerElementArrayTemplateFbxVector2 ret = new FbxLayerElementArrayTemplateFbxVector2(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_GetDirectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxInt GetIndexArray() {
    FbxLayerElementArrayTemplateFbxInt ret = new FbxLayerElementArrayTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_GetIndexArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override bool Clear() {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_Clear(swigCPtr);
    return ret;
  }

  public bool eq(FbxLayerElementTemplateFbxVector2 pOther) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_eq(swigCPtr, FbxLayerElementTemplateFbxVector2.getCPtr(pOther));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementTemplateFbxVector2 assign(FbxLayerElementTemplateFbxVector2 pOther) {
    FbxLayerElementTemplateFbxVector2 ret = new FbxLayerElementTemplateFbxVector2(FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_assign(swigCPtr, FbxLayerElementTemplateFbxVector2.getCPtr(pOther)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemapIndexTo(FbxLayerElement.EMappingMode pNewMapping) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_RemapIndexTo(swigCPtr, (int)pNewMapping);
    return ret;
  }

  public override int MemorySize() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_MemorySize(swigCPtr);
    return ret;
  }

  public override bool ContentWriteTo(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_ContentWriteTo(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool ContentReadFrom(FbxStream pStream) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_ContentReadFrom(swigCPtr, FbxStream.getCPtr(pStream));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxVector2 mDirectArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_mDirectArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxVector2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_mDirectArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxVector2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxVector2(cPtr, false);
      return ret;
    } 
  }

  public FbxLayerElementArrayTemplateFbxInt mIndexArray {
    set {
      FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_mIndexArray_set(swigCPtr, FbxLayerElementArrayTemplateFbxInt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementTemplateFbxVector2_mIndexArray_get(swigCPtr);
      FbxLayerElementArrayTemplateFbxInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementArrayTemplateFbxInt(cPtr, false);
      return ret;
    } 
  }

}

}
