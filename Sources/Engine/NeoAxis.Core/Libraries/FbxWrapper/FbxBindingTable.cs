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

public class FbxBindingTable : FbxBindingTableBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxBindingTable(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FbxWrapperNativePINVOKE.FbxBindingTable_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxBindingTable obj) {
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
      FbxWrapperNativePINVOKE.FbxBindingTable_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(FbxWrapperNativePINVOKE.FbxBindingTable_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxBindingTable Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxBindingTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBindingTable(cPtr, false);
    return ret;
  }

  public new static FbxBindingTable Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxBindingTable ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxBindingTable(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t TargetName {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_TargetName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_TargetName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t TargetType {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_TargetType_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_TargetType_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_DescRelativeURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_DescRelativeURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_DescAbsoluteURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_DescAbsoluteURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t DescTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_DescTAG_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_DescTAG_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_CodeRelativeURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_CodeRelativeURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_CodeAbsoluteURL_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_CodeAbsoluteURL_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t CodeTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_CodeTAG_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxBindingTable_CodeTAG_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public static string sTargetName {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sTargetName_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sTargetName_get();
      return ret;
    } 
  }

  public static string sTargetType {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sTargetType_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sTargetType_get();
      return ret;
    } 
  }

  public static string sDescRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDescRelativeURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDescRelativeURL_get();
      return ret;
    } 
  }

  public static string sDescAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDescAbsoluteURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDescAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDescTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDescTAG_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDescTAG_get();
      return ret;
    } 
  }

  public static string sCodeRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sCodeRelativeURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sCodeRelativeURL_get();
      return ret;
    } 
  }

  public static string sCodeAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sCodeAbsoluteURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sCodeAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sCodeTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sCodeTAG_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sCodeTAG_get();
      return ret;
    } 
  }

  public static string sDefaultTargetName {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultTargetName_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultTargetName_get();
      return ret;
    } 
  }

  public static string sDefaultTargetType {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultTargetType_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultTargetType_get();
      return ret;
    } 
  }

  public static string sDefaultDescRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescRelativeURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescRelativeURL_get();
      return ret;
    } 
  }

  public static string sDefaultDescAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescAbsoluteURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDefaultDescTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescTAG_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultDescTAG_get();
      return ret;
    } 
  }

  public static string sDefaultCodeRelativeURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeRelativeURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeRelativeURL_get();
      return ret;
    } 
  }

  public static string sDefaultCodeAbsoluteURL {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeAbsoluteURL_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeAbsoluteURL_get();
      return ret;
    } 
  }

  public static string sDefaultCodeTAG {
    set {
      FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeTAG_set(value);
    } 
    get {
      string ret = FbxWrapperNativePINVOKE.FbxBindingTable_sDefaultCodeTAG_get();
      return ret;
    } 
  }

}

}
