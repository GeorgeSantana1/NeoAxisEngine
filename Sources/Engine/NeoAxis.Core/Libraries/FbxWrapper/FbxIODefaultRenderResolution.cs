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

public class FbxIODefaultRenderResolution : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxIODefaultRenderResolution(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxIODefaultRenderResolution obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxIODefaultRenderResolution() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxIODefaultRenderResolution(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool mIsOK {
    set {
      FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mIsOK_set(swigCPtr, value);
    } 
    get {
      bool ret = FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mIsOK_get(swigCPtr);
      return ret;
    } 
  }

  public FbxString mCameraName {
    set {
      FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mCameraName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mCameraName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public FbxString mResolutionMode {
    set {
      FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionMode_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionMode_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

  public double mResolutionW {
    set {
      FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionW_set(swigCPtr, value);
    } 
    get {
      double ret = FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionW_get(swigCPtr);
      return ret;
    } 
  }

  public double mResolutionH {
    set {
      FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionH_set(swigCPtr, value);
    } 
    get {
      double ret = FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_mResolutionH_get(swigCPtr);
      return ret;
    } 
  }

  public FbxIODefaultRenderResolution() : this(FbxWrapperNativePINVOKE.new_FbxIODefaultRenderResolution(), true) {
  }

  public void Reset() {
    FbxWrapperNativePINVOKE.FbxIODefaultRenderResolution_Reset(swigCPtr);
  }

}

}
