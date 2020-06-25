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

public class FbxLayerElementArrayTemplateFbxInt : FbxLayerElementArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementArrayTemplateFbxInt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementArrayTemplateFbxInt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementArrayTemplateFbxInt() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxLayerElementArrayTemplateFbxInt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxLayerElementArrayTemplateFbxInt(EFbxType pDataType) : this(FbxWrapperNativePINVOKE.new_FbxLayerElementArrayTemplateFbxInt((int)pDataType), true) {
  }

  public int Add(int pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_Add(swigCPtr, pItem);
    return ret;
  }

  public int InsertAt(int pIndex, int pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_InsertAt(swigCPtr, pIndex, pItem);
    return ret;
  }

  public void SetAt(int pIndex, int pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_SetAt(swigCPtr, pIndex, pItem);
  }

  public void SetLast(int pItem) {
    FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_SetLast(swigCPtr, pItem);
  }

  public int RemoveAt(int pIndex) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_RemoveAt(swigCPtr, pIndex);
    return ret;
  }

  public int RemoveLast() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_RemoveLast(swigCPtr);
    return ret;
  }

  public bool RemoveIt(int pItem) {
    bool ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_RemoveIt(swigCPtr, pItem);
    return ret;
  }

  public int GetAt(int pIndex) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_GetAt(swigCPtr, pIndex);
    return ret;
  }

  public int GetFirst() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_GetFirst(swigCPtr);
    return ret;
  }

  public int GetLast() {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_GetLast(swigCPtr);
    return ret;
  }

  public int Find(int pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_Find(swigCPtr, pItem);
    return ret;
  }

  public int FindAfter(int pAfterIndex, int pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_FindAfter(swigCPtr, pAfterIndex, pItem);
    return ret;
  }

  public int FindBefore(int pBeforeIndex, int pItem) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_FindBefore(swigCPtr, pBeforeIndex, pItem);
    return ret;
  }

  public int at(int pIndex) {
    int ret = FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_at(swigCPtr, pIndex);
    return ret;
  }

  public FbxLayerElementArray assign(FbxArrayInt pArrayTemplate) {
    FbxLayerElementArray ret = new FbxLayerElementArray(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_assign__SWIG_0(swigCPtr, FbxArrayInt.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementArrayTemplateFbxInt assign(FbxLayerElementArrayTemplateFbxInt pArrayTemplate) {
    FbxLayerElementArrayTemplateFbxInt ret = new FbxLayerElementArrayTemplateFbxInt(FbxWrapperNativePINVOKE.FbxLayerElementArrayTemplateFbxInt_assign__SWIG_1(swigCPtr, FbxLayerElementArrayTemplateFbxInt.getCPtr(pArrayTemplate)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
