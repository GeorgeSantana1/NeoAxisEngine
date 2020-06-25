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

public class FbxDouble3x4 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxDouble3x4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxDouble3x4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxDouble3x4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxDouble3x4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxDouble3x4() : this(FbxWrapperNativePINVOKE.new_FbxDouble3x4__SWIG_0(), true) {
  }

  public FbxDouble3x4(FbxDouble4 pValue) : this(FbxWrapperNativePINVOKE.new_FbxDouble3x4__SWIG_1(FbxDouble4.getCPtr(pValue)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxDouble3x4(FbxDouble4 pData0, FbxDouble4 pData1, FbxDouble4 pData2) : this(FbxWrapperNativePINVOKE.new_FbxDouble3x4__SWIG_2(FbxDouble4.getCPtr(pData0), FbxDouble4.getCPtr(pData1), FbxDouble4.getCPtr(pData2)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxDouble4 at(int pIndex) {
    FbxDouble4 ret = new FbxDouble4(FbxWrapperNativePINVOKE.FbxDouble3x4_at__SWIG_0(swigCPtr, pIndex), false);
    return ret;
  }

  public FbxDouble2x4 ToFbxVectorTemplate2() {
    FbxDouble2x4 ret = new FbxDouble2x4(FbxWrapperNativePINVOKE.FbxDouble3x4_ToFbxVectorTemplate2(swigCPtr), false);
    return ret;
  }

  public FbxDouble3x4 assign(FbxDouble4 pValue) {
    FbxDouble3x4 ret = new FbxDouble3x4(FbxWrapperNativePINVOKE.FbxDouble3x4_assign__SWIG_0(swigCPtr, FbxDouble4.getCPtr(pValue)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble3x4 assign(FbxDouble2x4 pVector) {
    FbxDouble3x4 ret = new FbxDouble3x4(FbxWrapperNativePINVOKE.FbxDouble3x4_assign__SWIG_1(swigCPtr, FbxDouble2x4.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble3x4 assign(FbxDouble3x4 pVector) {
    FbxDouble3x4 ret = new FbxDouble3x4(FbxWrapperNativePINVOKE.FbxDouble3x4_assign__SWIG_2(swigCPtr, FbxDouble3x4.getCPtr(pVector)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(FbxDouble3x4 pVector) {
    bool ret = FbxWrapperNativePINVOKE.FbxDouble3x4_eq(swigCPtr, FbxDouble3x4.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxDouble3x4 pVector) {
    bool ret = FbxWrapperNativePINVOKE.FbxDouble3x4_ne(swigCPtr, FbxDouble3x4.getCPtr(pVector));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble4 Buffer() {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxDouble3x4_Buffer__SWIG_0(swigCPtr);
    FbxDouble4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble4(cPtr, false);
    return ret;
  }

  public FbxDouble4 mData {
    set {
      FbxWrapperNativePINVOKE.FbxDouble3x4_mData_set(swigCPtr, FbxDouble4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxDouble3x4_mData_get(swigCPtr);
      FbxDouble4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble4(cPtr, false);
      return ret;
    } 
  }

}

}
