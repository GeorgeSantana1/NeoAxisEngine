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

public class FbxCloneManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxCloneManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCloneManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxCloneManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxCloneManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static int sMaximumCloneDepth {
    get {
      int ret = FbxWrapperNativePINVOKE.FbxCloneManager_sMaximumCloneDepth_get();
      return ret;
    } 
  }

  public static int sConnectToOriginal {
    get {
      int ret = FbxWrapperNativePINVOKE.FbxCloneManager_sConnectToOriginal_get();
      return ret;
    } 
  }

  public static int sConnectToClone {
    get {
      int ret = FbxWrapperNativePINVOKE.FbxCloneManager_sConnectToClone_get();
      return ret;
    } 
  }

  public class CloneSetElement : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal CloneSetElement(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CloneSetElement obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~CloneSetElement() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            FbxWrapperNativePINVOKE.delete_FbxCloneManager_CloneSetElement(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public CloneSetElement(int pSrcPolicy, int pExternalDstPolicy, FbxObject.ECloneType pCloneType) : this(FbxWrapperNativePINVOKE.new_FbxCloneManager_CloneSetElement__SWIG_0(pSrcPolicy, pExternalDstPolicy, (int)pCloneType), true) {
    }
  
    public CloneSetElement(int pSrcPolicy, int pExternalDstPolicy) : this(FbxWrapperNativePINVOKE.new_FbxCloneManager_CloneSetElement__SWIG_1(pSrcPolicy, pExternalDstPolicy), true) {
    }
  
    public CloneSetElement(int pSrcPolicy) : this(FbxWrapperNativePINVOKE.new_FbxCloneManager_CloneSetElement__SWIG_2(pSrcPolicy), true) {
    }
  
    public CloneSetElement() : this(FbxWrapperNativePINVOKE.new_FbxCloneManager_CloneSetElement__SWIG_3(), true) {
    }
  
    public FbxObject.ECloneType mType {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mType_set(swigCPtr, (int)value);
      } 
      get {
        FbxObject.ECloneType ret = (FbxObject.ECloneType)FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mType_get(swigCPtr);
        return ret;
      } 
    }
  
    public int mSrcPolicy {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mSrcPolicy_set(swigCPtr, value);
      } 
      get {
        int ret = FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mSrcPolicy_get(swigCPtr);
        return ret;
      } 
    }
  
    public int mExternalDstPolicy {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mExternalDstPolicy_set(swigCPtr, value);
      } 
      get {
        int ret = FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mExternalDstPolicy_get(swigCPtr);
        return ret;
      } 
    }
  
    public FbxObject mObjectClone {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mObjectClone_set(swigCPtr, FbxObject.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mObjectClone_get(swigCPtr);
        FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
        return ret;
      } 
    }
  
    public bool mLayerElementProcessed {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mLayerElementProcessed_set(swigCPtr, value);
      } 
      get {
        bool ret = FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mLayerElementProcessed_get(swigCPtr);
        return ret;
      } 
    }
  
    public bool mConnectionsProcessed {
      set {
        FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mConnectionsProcessed_set(swigCPtr, value);
      } 
      get {
        bool ret = FbxWrapperNativePINVOKE.FbxCloneManager_CloneSetElement_mConnectionsProcessed_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public FbxCloneManager() : this(FbxWrapperNativePINVOKE.new_FbxCloneManager(), true) {
  }

  public static FbxObject Clone(FbxObject pObject, FbxObject pContainer) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_0(FbxObject.getCPtr(pObject), FbxObject.getCPtr(pContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public static FbxObject Clone(FbxObject pObject) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_1(FbxObject.getCPtr(pObject));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public virtual bool Clone(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pContainer) {
    bool ret = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_2(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pContainer));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Clone(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet) {
    bool ret = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_3(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void AddDependents(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pObject, FbxCloneManager.CloneSetElement pCloneOptions, FbxCriteria pTypes, int pDepth) {
    FbxWrapperNativePINVOKE.FbxCloneManager_AddDependents__SWIG_0(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pObject), FbxCloneManager.CloneSetElement.getCPtr(pCloneOptions), FbxCriteria.getCPtr(pTypes), pDepth);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddDependents(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pObject, FbxCloneManager.CloneSetElement pCloneOptions, FbxCriteria pTypes) {
    FbxWrapperNativePINVOKE.FbxCloneManager_AddDependents__SWIG_1(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pObject), FbxCloneManager.CloneSetElement.getCPtr(pCloneOptions), FbxCriteria.getCPtr(pTypes));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddDependents(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pObject, FbxCloneManager.CloneSetElement pCloneOptions) {
    FbxWrapperNativePINVOKE.FbxCloneManager_AddDependents__SWIG_2(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pObject), FbxCloneManager.CloneSetElement.getCPtr(pCloneOptions));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddDependents(SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pObject) {
    FbxWrapperNativePINVOKE.FbxCloneManager_AddDependents__SWIG_3(swigCPtr, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pObject));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public static FbxObject Clone(FbxObject pObject, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet, FbxObject pContainer) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_4(FbxObject.getCPtr(pObject), SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet), FbxObject.getCPtr(pContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public static FbxObject Clone(FbxObject pObject, SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t pSet) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxCloneManager_Clone__SWIG_5(FbxObject.getCPtr(pObject), SWIGTYPE_p_FbxMapT_FbxObject_p_FbxCloneManager__CloneSetElement_FbxLessCompareT_FbxObject_p_t_FbxBaseAllocator_t.getCPtr(pSet));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

}

}
