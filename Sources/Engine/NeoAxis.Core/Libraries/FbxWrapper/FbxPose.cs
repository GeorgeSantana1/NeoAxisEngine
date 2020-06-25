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

public class FbxPose : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPose(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxPose_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPose obj) {
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
      FbxWrapperNativePINVOKE.FbxPose_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPose_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxPose_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxPose Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPose_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxPose ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPose(cPtr, false);
    return ret;
  }

  public new static FbxPose Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPose_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxPose ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPose(cPtr, false);
    return ret;
  }

  public void SetIsBindPose(bool pIsBindPose) {
    FbxWrapperNativePINVOKE.FbxPose_SetIsBindPose(swigCPtr, pIsBindPose);
  }

  public bool IsBindPose() {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsBindPose(swigCPtr);
    return ret;
  }

  public bool IsRestPose() {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsRestPose(swigCPtr);
    return ret;
  }

  public int GetCount() {
    int ret = FbxWrapperNativePINVOKE.FbxPose_GetCount(swigCPtr);
    return ret;
  }

  public int Add(FbxNode pNode, FbxMatrix pMatrix, bool pLocalMatrix, bool pMultipleBindPose) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Add__SWIG_0(swigCPtr, FbxNode.getCPtr(pNode), FbxMatrix.getCPtr(pMatrix), pLocalMatrix, pMultipleBindPose);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Add(FbxNode pNode, FbxMatrix pMatrix, bool pLocalMatrix) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Add__SWIG_1(swigCPtr, FbxNode.getCPtr(pNode), FbxMatrix.getCPtr(pMatrix), pLocalMatrix);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Add(FbxNode pNode, FbxMatrix pMatrix) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Add__SWIG_2(swigCPtr, FbxNode.getCPtr(pNode), FbxMatrix.getCPtr(pMatrix));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Remove(int pIndex) {
    FbxWrapperNativePINVOKE.FbxPose_Remove(swigCPtr, pIndex);
  }

  public FbxNameHandler GetNodeName(int pIndex) {
    FbxNameHandler ret = new FbxNameHandler(FbxWrapperNativePINVOKE.FbxPose_GetNodeName(swigCPtr, pIndex), true);
    return ret;
  }

  public FbxNode GetNode(int pIndex) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxPose_GetNode(swigCPtr, pIndex);
    FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
    return ret;
  }

  public FbxMatrix GetMatrix(int pIndex) {
    FbxMatrix ret = new FbxMatrix(FbxWrapperNativePINVOKE.FbxPose_GetMatrix(swigCPtr, pIndex), false);
    return ret;
  }

  public bool IsLocalMatrix(int pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsLocalMatrix(swigCPtr, pIndex);
    return ret;
  }

  public int Find(FbxNameHandler pNodeName, char pCompareWhat) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Find__SWIG_0(swigCPtr, FbxNameHandler.getCPtr(pNodeName), pCompareWhat);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Find(FbxNameHandler pNodeName) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Find__SWIG_1(swigCPtr, FbxNameHandler.getCPtr(pNodeName));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Find(FbxNode pNode) {
    int ret = FbxWrapperNativePINVOKE.FbxPose_Find__SWIG_2(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public static bool GetPosesContaining(FbxManager pManager, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetPosesContaining__SWIG_0(FbxManager.getCPtr(pManager), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetPosesContaining(FbxScene pScene, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetPosesContaining__SWIG_1(FbxScene.getCPtr(pScene), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetBindPoseContaining(FbxManager pManager, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetBindPoseContaining__SWIG_0(FbxManager.getCPtr(pManager), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetBindPoseContaining(FbxScene pScene, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetBindPoseContaining__SWIG_1(FbxScene.getCPtr(pScene), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetRestPoseContaining(FbxManager pManager, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetRestPoseContaining__SWIG_0(FbxManager.getCPtr(pManager), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GetRestPoseContaining(FbxScene pScene, FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxPose_p_t pPoseList, FbxArrayInt pIndex) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_GetRestPoseContaining__SWIG_1(FbxScene.getCPtr(pScene), FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxPose_p_t.getCPtr(pPoseList), FbxArrayInt.getCPtr(pIndex));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValidBindPose(FbxNode pRoot, double pMatrixCmpTolerance, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPose__SWIG_0(swigCPtr, FbxNode.getCPtr(pRoot), pMatrixCmpTolerance, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool IsValidBindPose(FbxNode pRoot, double pMatrixCmpTolerance) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPose__SWIG_1(swigCPtr, FbxNode.getCPtr(pRoot), pMatrixCmpTolerance);
    return ret;
  }

  public bool IsValidBindPose(FbxNode pRoot) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPose__SWIG_2(swigCPtr, FbxNode.getCPtr(pRoot));
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformers, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformersAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pWrongMatrices, double pMatrixCmpTolerance, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_0(swigCPtr, FbxNode.getCPtr(pRoot), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformers), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformersAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pWrongMatrices), pMatrixCmpTolerance, FbxStatus.getCPtr(pStatus));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformers, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformersAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pWrongMatrices, double pMatrixCmpTolerance) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_1(swigCPtr, FbxNode.getCPtr(pRoot), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformers), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformersAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pWrongMatrices), pMatrixCmpTolerance);
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformers, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMissingDeformersAncestors, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pWrongMatrices) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_2(swigCPtr, FbxNode.getCPtr(pRoot), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformers), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMissingDeformersAncestors), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pWrongMatrices));
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, FbxUserNotification pUserNotification, double pMatrixCmpTolerance, FbxStatus pStatus) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_3(swigCPtr, FbxNode.getCPtr(pRoot), FbxUserNotification.getCPtr(pUserNotification), pMatrixCmpTolerance, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, FbxUserNotification pUserNotification, double pMatrixCmpTolerance) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_4(swigCPtr, FbxNode.getCPtr(pRoot), FbxUserNotification.getCPtr(pUserNotification), pMatrixCmpTolerance);
    return ret;
  }

  public bool IsValidBindPoseVerbose(FbxNode pRoot, FbxUserNotification pUserNotification) {
    bool ret = FbxWrapperNativePINVOKE.FbxPose_IsValidBindPoseVerbose__SWIG_5(swigCPtr, FbxNode.getCPtr(pRoot), FbxUserNotification.getCPtr(pUserNotification));
    return ret;
  }

  public enum ENameComponent {
    eInitialNameComponent = 1,
    eCurrentNameComponent = 2,
    eAllNameComponents = 3
  }

}

}
