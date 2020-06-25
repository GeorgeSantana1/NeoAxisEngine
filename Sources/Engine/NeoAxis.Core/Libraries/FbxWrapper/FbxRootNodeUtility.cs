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

public class FbxRootNodeUtility : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxRootNodeUtility(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRootNodeUtility obj) {
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

  public static string sFbxRootNodePrefix {
    set {
      FbxWrapperNativePINVOKE.FbxRootNodeUtility_sFbxRootNodePrefix_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxRootNodeUtility_sFbxRootNodePrefix_get();
      return ret;
    } 
  }

  public static bool RemoveAllFbxRoots(FbxScene pScene) {
    bool ret = FbxWrapperNativePINVOKE.FbxRootNodeUtility_RemoveAllFbxRoots(FbxScene.getCPtr(pScene));
    return ret;
  }

  public static bool InsertFbxRoot(FbxScene pScene, FbxAxisSystem pDstAxis, FbxSystemUnit pDstUnit, FbxSystemUnit.ConversionOptions pUnitOptions) {
    bool ret = FbxWrapperNativePINVOKE.FbxRootNodeUtility_InsertFbxRoot__SWIG_0(FbxScene.getCPtr(pScene), FbxAxisSystem.getCPtr(pDstAxis), FbxSystemUnit.getCPtr(pDstUnit), FbxSystemUnit.ConversionOptions.getCPtr(pUnitOptions));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool InsertFbxRoot(FbxScene pScene, FbxAxisSystem pDstAxis, FbxSystemUnit pDstUnit) {
    bool ret = FbxWrapperNativePINVOKE.FbxRootNodeUtility_InsertFbxRoot__SWIG_1(FbxScene.getCPtr(pScene), FbxAxisSystem.getCPtr(pDstAxis), FbxSystemUnit.getCPtr(pDstUnit));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsFbxRootNode(FbxNode pNode) {
    bool ret = FbxWrapperNativePINVOKE.FbxRootNodeUtility_IsFbxRootNode(FbxNode.getCPtr(pNode));
    return ret;
  }

}

}
