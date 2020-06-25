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

public class FbxThread : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxThread(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxThread obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxThread() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxThread(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxThread(SWIGTYPE_p_f_p_void__void pProc, SWIGTYPE_p_void pArg, bool pSuspend) : this(FbxWrapperNativePINVOKE.new_FbxThread__SWIG_0(SWIGTYPE_p_f_p_void__void.getCPtr(pProc), SWIGTYPE_p_void.getCPtr(pArg), pSuspend), true) {
  }

  public FbxThread(SWIGTYPE_p_f_p_void__void pProc, SWIGTYPE_p_void pArg) : this(FbxWrapperNativePINVOKE.new_FbxThread__SWIG_1(SWIGTYPE_p_f_p_void__void.getCPtr(pProc), SWIGTYPE_p_void.getCPtr(pArg)), true) {
  }

  public FbxThread(SWIGTYPE_p_f_p_void__void pProc, SWIGTYPE_p_void pArg, FbxThread.EPriority pPriority, bool pSuspend) : this(FbxWrapperNativePINVOKE.new_FbxThread__SWIG_2(SWIGTYPE_p_f_p_void__void.getCPtr(pProc), SWIGTYPE_p_void.getCPtr(pArg), (int)pPriority, pSuspend), true) {
  }

  public FbxThread(SWIGTYPE_p_f_p_void__void pProc, SWIGTYPE_p_void pArg, FbxThread.EPriority pPriority) : this(FbxWrapperNativePINVOKE.new_FbxThread__SWIG_3(SWIGTYPE_p_f_p_void__void.getCPtr(pProc), SWIGTYPE_p_void.getCPtr(pArg), (int)pPriority), true) {
  }

  public bool Suspend() {
    bool ret = FbxWrapperNativePINVOKE.FbxThread_Suspend(swigCPtr);
    return ret;
  }

  public bool Resume() {
    bool ret = FbxWrapperNativePINVOKE.FbxThread_Resume(swigCPtr);
    return ret;
  }

  public bool Join() {
    bool ret = FbxWrapperNativePINVOKE.FbxThread_Join(swigCPtr);
    return ret;
  }

  public bool Kill() {
    bool ret = FbxWrapperNativePINVOKE.FbxThread_Kill(swigCPtr);
    return ret;
  }

  public FbxThread.EPriority GetPriority() {
    FbxThread.EPriority ret = (FbxThread.EPriority)FbxWrapperNativePINVOKE.FbxThread_GetPriority(swigCPtr);
    return ret;
  }

  public bool SetPriority(FbxThread.EPriority pPriority) {
    bool ret = FbxWrapperNativePINVOKE.FbxThread_SetPriority(swigCPtr, (int)pPriority);
    return ret;
  }

  public FbxThread.EState GetState() {
    FbxThread.EState ret = (FbxThread.EState)FbxWrapperNativePINVOKE.FbxThread_GetState(swigCPtr);
    return ret;
  }

  public enum EState {
    eUnknown,
    eRunning,
    eDead
  }

  public enum EPriority {
    eNone,
    eIdle,
    eLowest,
    eLow,
    eNormal,
    eHigh,
    eHighest,
    eRealTime
  }

}

}
