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

public class FbxVectorDegreeToVectorRadianBOF : FbxBindingOperator.Function {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxVectorDegreeToVectorRadianBOF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxVectorDegreeToVectorRadianBOF_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxVectorDegreeToVectorRadianBOF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxVectorDegreeToVectorRadianBOF() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxVectorDegreeToVectorRadianBOF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static string FunctionName {
    set {
      FbxWrapperNativePINVOKE.FbxVectorDegreeToVectorRadianBOF_FunctionName_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxVectorDegreeToVectorRadianBOF_FunctionName_get();
      return ret;
    } 
  }

  public override bool Evaluate(FbxBindingOperator pOperator, FbxObject pObject, SWIGTYPE_p_EFbxType pResultType, SWIGTYPE_p_p_void pResult) {
    bool ret = FbxWrapperNativePINVOKE.FbxVectorDegreeToVectorRadianBOF_Evaluate(swigCPtr, FbxBindingOperator.getCPtr(pOperator), FbxObject.getCPtr(pObject), SWIGTYPE_p_EFbxType.getCPtr(pResultType), SWIGTYPE_p_p_void.getCPtr(pResult));
    return ret;
  }

  public override bool ReverseEvaluate(FbxBindingOperator pOperator, FbxObject pTarget, SWIGTYPE_p_void pIn, SWIGTYPE_p_p_void pOut, SWIGTYPE_p_EFbxType pOutType, bool setObj, int index) {
    bool ret = FbxWrapperNativePINVOKE.FbxVectorDegreeToVectorRadianBOF_ReverseEvaluate(swigCPtr, FbxBindingOperator.getCPtr(pOperator), FbxObject.getCPtr(pTarget), SWIGTYPE_p_void.getCPtr(pIn), SWIGTYPE_p_p_void.getCPtr(pOut), SWIGTYPE_p_EFbxType.getCPtr(pOutType), setObj, index);
    return ret;
  }

  public FbxVectorDegreeToVectorRadianBOF() : this(FbxWrapperNativePINVOKE.new_FbxVectorDegreeToVectorRadianBOF(), true) {
  }

}

}
