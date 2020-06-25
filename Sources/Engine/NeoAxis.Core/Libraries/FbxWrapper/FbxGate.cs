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

public class FbxGate : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxGate(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxGate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxGate() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxGate(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxGate() : this(FbxWrapperNativePINVOKE.new_FbxGate(), true) {
  }

  public void Open() {
    FbxWrapperNativePINVOKE.FbxGate_Open(swigCPtr);
  }

  public void Close() {
    FbxWrapperNativePINVOKE.FbxGate_Close(swigCPtr);
  }

  public bool IsOpen() {
    bool ret = FbxWrapperNativePINVOKE.FbxGate_IsOpen(swigCPtr);
    return ret;
  }

  public bool Wait() {
    bool ret = FbxWrapperNativePINVOKE.FbxGate_Wait(swigCPtr);
    return ret;
  }

}

}
