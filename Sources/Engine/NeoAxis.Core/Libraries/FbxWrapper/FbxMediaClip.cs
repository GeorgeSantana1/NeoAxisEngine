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

public class FbxMediaClip : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxMediaClip(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxMediaClip_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxMediaClip obj) {
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
      FbxWrapperNativePINVOKE.FbxMediaClip_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxMediaClip_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxMediaClip Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_Create(FbxManager.getCPtr(pManager), pName);
    FbxMediaClip ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxMediaClip(cPtr, false);
    return ret;
  }

  public virtual void Reset() {
    FbxWrapperNativePINVOKE.FbxMediaClip_Reset(swigCPtr);
  }

  public virtual bool SetFileName(string pName) {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_SetFileName(swigCPtr, pName);
    return ret;
  }

  public FbxString GetFileName() {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxMediaClip_GetFileName(swigCPtr), true);
    return ret;
  }

  public virtual bool SetRelativeFileName(string pName) {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_SetRelativeFileName(swigCPtr, pName);
    return ret;
  }

  public FbxString GetRelativeFileName() {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxMediaClip_GetRelativeFileName(swigCPtr), true);
    return ret;
  }

  public void SetColor(FbxColor pColor) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetColor(swigCPtr, FbxColor.getCPtr(pColor));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxColor GetColor() {
    FbxColor ret = new FbxColor(FbxWrapperNativePINVOKE.FbxMediaClip_GetColor(swigCPtr), true);
    return ret;
  }

  public void SetPlaySpeed(double pPlaySpeed) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetPlaySpeed(swigCPtr, pPlaySpeed);
  }

  public double GetPlaySpeed() {
    double ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetPlaySpeed(swigCPtr);
    return ret;
  }

  public void SetClipIn(FbxTime pTime) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetClipIn(swigCPtr, FbxTime.getCPtr(pTime));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetClipIn() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxMediaClip_GetClipIn(swigCPtr), true);
    return ret;
  }

  public void SetClipOut(FbxTime pTime) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetClipOut(swigCPtr, FbxTime.getCPtr(pTime));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetClipOut() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxMediaClip_GetClipOut(swigCPtr), true);
    return ret;
  }

  public void SetOffset(FbxTime pTime) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetOffset(swigCPtr, FbxTime.getCPtr(pTime));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetOffset() {
    FbxTime ret = new FbxTime(FbxWrapperNativePINVOKE.FbxMediaClip_GetOffset(swigCPtr), true);
    return ret;
  }

  public void SetFreeRunning(bool pState) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetFreeRunning(swigCPtr, pState);
  }

  public bool GetFreeRunning() {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetFreeRunning(swigCPtr);
    return ret;
  }

  public void SetLoop(bool pLoop) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetLoop(swigCPtr, pLoop);
  }

  public bool GetLoop() {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetLoop(swigCPtr);
    return ret;
  }

  public void SetMute(bool pMute) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetMute(swigCPtr, pMute);
  }

  public bool GetMute() {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetMute(swigCPtr);
    return ret;
  }

  public void SetAccessMode(FbxMediaClip.EAccessMode pAccessMode) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetAccessMode(swigCPtr, (int)pAccessMode);
  }

  public FbxMediaClip.EAccessMode GetAccessMode() {
    FbxMediaClip.EAccessMode ret = (FbxMediaClip.EAccessMode)FbxWrapperNativePINVOKE.FbxMediaClip_GetAccessMode(swigCPtr);
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(FbxWrapperNativePINVOKE.FbxMediaClip_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxStringList GetTypeFlags() {
    FbxStringList ret = new FbxStringList(FbxWrapperNativePINVOKE.FbxMediaClip_GetTypeFlags(swigCPtr), true);
    return ret;
  }

  public void SetOriginalFormat(bool pState) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetOriginalFormat(swigCPtr, pState);
  }

  public bool GetOriginalFormat() {
    bool ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetOriginalFormat(swigCPtr);
    return ret;
  }

  public void SetOriginalFilename(string pOriginalFilename) {
    FbxWrapperNativePINVOKE.FbxMediaClip_SetOriginalFilename(swigCPtr, pOriginalFilename);
  }

  public string GetOriginalFilename() {
    string ret = FbxWrapperNativePINVOKE.FbxMediaClip_GetOriginalFilename(swigCPtr);
    return ret;
  }

  public FbxPropertyTFbxDouble3 Color {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_Color_set(swigCPtr, FbxPropertyTFbxDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_Color_get(swigCPtr);
      FbxPropertyTFbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTime_t ClipIn {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_ClipIn_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTime_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_ClipIn_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTime_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTime_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTime_t ClipOut {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_ClipOut_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTime_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_ClipOut_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTime_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTime_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxTime_t Offset {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_Offset_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxTime_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_Offset_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxTime_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxTime_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTFbxDouble PlaySpeed {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_PlaySpeed_set(swigCPtr, FbxPropertyTFbxDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_PlaySpeed_get(swigCPtr);
      FbxPropertyTFbxDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTFbxDouble(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t FreeRunning {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_FreeRunning_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_FreeRunning_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Loop {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_Loop_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_Loop_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_bool_t Mute {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_Mute_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_bool_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_Mute_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_bool_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_bool_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxMediaClip__EAccessMode_t AccessMode {
    set {
      FbxWrapperNativePINVOKE.FbxMediaClip_AccessMode_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxMediaClip__EAccessMode_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxMediaClip_AccessMode_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxMediaClip__EAccessMode_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxMediaClip__EAccessMode_t(cPtr, false);
      return ret;
    } 
  }

  public enum EAccessMode {
    eDisk,
    eMemory,
    eDiskAsync
  }

}

}