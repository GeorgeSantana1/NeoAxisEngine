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

public class FbxEuler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxEuler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEuler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEuler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxEuler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool IsParityOdd(FbxEuler.EOrder pOrder) {
    bool ret = FbxWrapperNativePINVOKE.FbxEuler_IsParityOdd((int)pOrder);
    return ret;
  }

  public static bool IsRepeat(FbxEuler.EOrder pOrder) {
    bool ret = FbxWrapperNativePINVOKE.FbxEuler_IsRepeat((int)pOrder);
    return ret;
  }

  public static int AxisTableSize {
    get {
      int ret = FbxWrapperNativePINVOKE.FbxEuler_AxisTableSize_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_a_3__int AxisTable {
    get {
      global::System.IntPtr cPtr = FbxWrapperNativePINVOKE.FbxEuler_AxisTable_get();
      SWIGTYPE_p_a_3__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_3__int(cPtr, false);
      return ret;
    } 
  }

  public static void SetDegenerateThreshold(double pThreshold) {
    FbxWrapperNativePINVOKE.FbxEuler_SetDegenerateThreshold__SWIG_0(pThreshold);
  }

  public static void SetDegenerateThreshold() {
    FbxWrapperNativePINVOKE.FbxEuler_SetDegenerateThreshold__SWIG_1();
  }

  public static double DegenerateThreshold() {
    double ret = FbxWrapperNativePINVOKE.FbxEuler_DegenerateThreshold();
    return ret;
  }

  public FbxEuler() : this(FbxWrapperNativePINVOKE.new_FbxEuler(), true) {
  }

  public enum EAxis {
    eAxisX = 0,
    eAxisY = 1,
    eAxisZ = 2
  }

  public enum EOrder {
    eOrderXYZ,
    eOrderXZY,
    eOrderYZX,
    eOrderYXZ,
    eOrderZXY,
    eOrderZYX,
    eOrderSphericXYZ
  }

}

}
