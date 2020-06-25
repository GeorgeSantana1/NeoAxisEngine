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

public class FbxLayerElementMaterial : FbxLayerElementTemplateFbxSurfaceMaterialPtr {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementMaterial(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementMaterial_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementMaterial obj) {
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

  public static FbxLayerElementMaterial Create(FbxLayerContainer pOwner, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxLayerElementMaterial_Create(FbxLayerContainer.getCPtr(pOwner), pName);
    FbxLayerElementMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementMaterial(cPtr, false);
    return ret;
  }

  public class LayerElementArrayProxy : FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
    internal LayerElementArrayProxy(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxLayerElementMaterial_LayerElementArrayProxy_SWIGUpcast(cPtr), cMemoryOwn) {
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LayerElementArrayProxy obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~LayerElementArrayProxy() {
      Dispose();
    }
  
    public override void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            FbxWrapperNativePINVOKE.delete_FbxLayerElementMaterial_LayerElementArrayProxy(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
        base.Dispose();
      }
    }
  
    public LayerElementArrayProxy(EFbxType pType) : this(FbxWrapperNativePINVOKE.new_FbxLayerElementMaterial_LayerElementArrayProxy((int)pType), true) {
    }
  
    public void SetContainer(FbxLayerContainer pContainer, int pInstance) {
      FbxWrapperNativePINVOKE.FbxLayerElementMaterial_LayerElementArrayProxy_SetContainer__SWIG_0(swigCPtr, FbxLayerContainer.getCPtr(pContainer), pInstance);
    }
  
    public void SetContainer(FbxLayerContainer pContainer) {
      FbxWrapperNativePINVOKE.FbxLayerElementMaterial_LayerElementArrayProxy_SetContainer__SWIG_1(swigCPtr, FbxLayerContainer.getCPtr(pContainer));
    }
  
  }

  public virtual void AllocateArrays() {
    FbxWrapperNativePINVOKE.FbxLayerElementMaterial_AllocateArrays(swigCPtr);
  }

  public virtual void SetOwner(FbxLayerContainer pOwner, int pInstance) {
    FbxWrapperNativePINVOKE.FbxLayerElementMaterial_SetOwner__SWIG_0(swigCPtr, FbxLayerContainer.getCPtr(pOwner), pInstance);
  }

  public virtual void SetOwner(FbxLayerContainer pOwner) {
    FbxWrapperNativePINVOKE.FbxLayerElementMaterial_SetOwner__SWIG_1(swigCPtr, FbxLayerContainer.getCPtr(pOwner));
  }

  public virtual void SetInstance(int pInstance) {
    FbxWrapperNativePINVOKE.FbxLayerElementMaterial_SetInstance(swigCPtr, pInstance);
  }

}

}
