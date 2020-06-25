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

public class FbxXRefManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxXRefManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxXRefManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxXRefManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxXRefManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxXRefManager() : this(FbxWrapperNativePINVOKE.new_FbxXRefManager(), true) {
  }

  public static string sTemporaryFileProject {
    set {
      FbxWrapperNativePINVOKE.FbxXRefManager_sTemporaryFileProject_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxXRefManager_sTemporaryFileProject_get();
      return ret;
    } 
  }

  public static string sConfigurationProject {
    set {
      FbxWrapperNativePINVOKE.FbxXRefManager_sConfigurationProject_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxXRefManager_sConfigurationProject_get();
      return ret;
    } 
  }

  public static string sLocalizationProject {
    set {
      FbxWrapperNativePINVOKE.FbxXRefManager_sLocalizationProject_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxXRefManager_sLocalizationProject_get();
      return ret;
    } 
  }

  public static string sEmbeddedFileProject {
    set {
      FbxWrapperNativePINVOKE.FbxXRefManager_sEmbeddedFileProject_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxXRefManager_sEmbeddedFileProject_get();
      return ret;
    } 
  }

  public static int GetUrlCount(FbxProperty pProperty) {
    int ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetUrlCount__SWIG_0(FbxProperty.getCPtr(pProperty));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int GetUrlCount(FbxString pUrl) {
    int ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetUrlCount__SWIG_1(FbxString.getCPtr(pUrl));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsRelativeUrl(FbxProperty pProperty, int pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_IsRelativeUrl(FbxProperty.getCPtr(pProperty), pIndex);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxString GetUrl(FbxProperty pProperty, int pIndex) {
    FbxString ret = new FbxString(FbxWrapperNativePINVOKE.FbxXRefManager_GetUrl(FbxProperty.getCPtr(pProperty), pIndex), true);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetResolvedUrl(FbxProperty pProperty, int pIndex, FbxString pResolvedPath) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetResolvedUrl__SWIG_0(swigCPtr, FbxProperty.getCPtr(pProperty), pIndex, FbxString.getCPtr(pResolvedPath));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetResolvedUrl(string pUrl, FbxDocument pDoc, FbxString pResolvedPath) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetResolvedUrl__SWIG_1(swigCPtr, pUrl, FbxDocument.getCPtr(pDoc), FbxString.getCPtr(pResolvedPath));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFirstMatchingUrl(string pPrefix, string pOptExt, FbxDocument pDoc, FbxString pResolvedPath) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetFirstMatchingUrl(swigCPtr, pPrefix, pOptExt, FbxDocument.getCPtr(pDoc), FbxString.getCPtr(pResolvedPath));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddXRefProject(string pName, string pUrl) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_AddXRefProject__SWIG_0(swigCPtr, pName, pUrl);
    return ret;
  }

  public bool AddXRefProject(string pName, string pExtension, string pUrl) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_AddXRefProject__SWIG_1(swigCPtr, pName, pExtension, pUrl);
    return ret;
  }

  public bool AddXRefProject(FbxDocument pDoc) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_AddXRefProject__SWIG_2(swigCPtr, FbxDocument.getCPtr(pDoc));
    return ret;
  }

  public bool RemoveXRefProject(string pName) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_RemoveXRefProject(swigCPtr, pName);
    return ret;
  }

  public bool RemoveAllXRefProjects() {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_RemoveAllXRefProjects(swigCPtr);
    return ret;
  }

  public int GetXRefProjectCount() {
    int ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetXRefProjectCount(swigCPtr);
    return ret;
  }

  public string GetXRefProjectName(int pIndex) {
    string ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetXRefProjectName(swigCPtr, pIndex);
    return ret;
  }

  public string GetXRefProjectUrl(string pName) {
    string ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetXRefProjectUrl__SWIG_0(swigCPtr, pName);
    return ret;
  }

  public string GetXRefProjectUrl(int pIndex) {
    string ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetXRefProjectUrl__SWIG_2(swigCPtr, pIndex);
    return ret;
  }

  public bool HasXRefProject(string pName) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_HasXRefProject(swigCPtr, pName);
    return ret;
  }

  public bool GetResolvedUrl(string pUrl, FbxString pResolvePath) {
    bool ret = FbxWrapperNativePINVOKE.FbxXRefManager_GetResolvedUrl__SWIG_2(swigCPtr, pUrl, FbxString.getCPtr(pResolvePath));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
