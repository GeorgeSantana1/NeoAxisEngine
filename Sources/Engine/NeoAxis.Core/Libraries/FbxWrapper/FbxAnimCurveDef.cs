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

public class FbxAnimCurveDef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveDef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveDef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveDef() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxAnimCurveDef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static float sDEFAULT_WEIGHT {
    get {
      float ret = FbxWrapperNativePINVOKE.FbxAnimCurveDef_sDEFAULT_WEIGHT_get();
      return ret;
    } 
  }

  public static float sMIN_WEIGHT {
    get {
      float ret = FbxWrapperNativePINVOKE.FbxAnimCurveDef_sMIN_WEIGHT_get();
      return ret;
    } 
  }

  public static float sMAX_WEIGHT {
    get {
      float ret = FbxWrapperNativePINVOKE.FbxAnimCurveDef_sMAX_WEIGHT_get();
      return ret;
    } 
  }

  public static float sDEFAULT_VELOCITY {
    get {
      float ret = FbxWrapperNativePINVOKE.FbxAnimCurveDef_sDEFAULT_VELOCITY_get();
      return ret;
    } 
  }

  public FbxAnimCurveDef() : this(FbxWrapperNativePINVOKE.new_FbxAnimCurveDef(), true) {
  }

  public enum ETangentMode {
    eTangentAuto = 0x00000100,
    eTangentTCB = 0x00000200,
    eTangentUser = 0x00000400,
    eTangentGenericBreak = 0x00000800,
    eTangentBreak = eTangentGenericBreak|eTangentUser,
    eTangentAutoBreak = eTangentGenericBreak|eTangentAuto,
    eTangentGenericClamp = 0x00001000,
    eTangentGenericTimeIndependent = 0x00002000,
    eTangentGenericClampProgressive = 0x00004000|eTangentGenericTimeIndependent
  }

  public enum EInterpolationType {
    eInterpolationConstant = 0x00000002,
    eInterpolationLinear = 0x00000004,
    eInterpolationCubic = 0x00000008
  }

  public enum EWeightedMode {
    eWeightedNone = 0x00000000,
    eWeightedRight = 0x01000000,
    eWeightedNextLeft = 0x02000000,
    eWeightedAll = eWeightedRight|eWeightedNextLeft
  }

  public enum EConstantMode {
    eConstantStandard = 0x00000000,
    eConstantNext = 0x00000100
  }

  public enum EVelocityMode {
    eVelocityNone = 0x00000000,
    eVelocityRight = 0x10000000,
    eVelocityNextLeft = 0x20000000,
    eVelocityAll = eVelocityRight|eVelocityNextLeft
  }

  public enum ETangentVisibility {
    eTangentShowNone = 0x00000000,
    eTangentShowLeft = 0x00100000,
    eTangentShowRight = 0x00200000,
    eTangentShowBoth = eTangentShowLeft|eTangentShowRight
  }

  public enum EDataIndex {
    eRightSlope = 0,
    eNextLeftSlope = 1,
    eWeights = 2,
    eRightWeight = 2,
    eNextLeftWeight = 3,
    eVelocity = 4,
    eRightVelocity = 4,
    eNextLeftVelocity = 5,
    eTCBTension = 0,
    eTCBContinuity = 1,
    eTCBBias = 2
  }

}

}
