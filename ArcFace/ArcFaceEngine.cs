using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace RfidAPI.ArcFace
{
    
    public class ArcFaceEngine
    {
        
        
        public struct ASF_VERSION
        {
            
            
            public IntPtr Version;
            
            public IntPtr BuilderDate;
            
            public IntPtr CopyRight;

        }
        #nullable enable
        public struct ASF_ActiveFileInfo
        {
            

            public IntPtr startTime;
            public IntPtr endTime;
            public IntPtr activeKey;
            public IntPtr platform;
            public IntPtr sdkType;
            public IntPtr appId;
            public IntPtr sdkKey;
            public IntPtr sdkVersion;
            public IntPtr fileVersion;
            
        }

        public struct MRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        
        public struct ASF_SingleFaceInfo
        {
            public MRECT faceRect;
            public int faceOrient;
        }

        public struct ASF_MultiFaceInfo
        {
            public IntPtr faceRect;
            public IntPtr faceOrient;
            public int faceNum;
            public IntPtr faceID;
        }
        
        public struct ASF_FaceFeature
        {
            public UIntPtr feature;
            public int featureSize;
        }
        public struct ASF_AgeInfo
        {
            public IntPtr ageArray;
            public int num;

        }
        
        public struct ASF_GenderInfo
        {
            public IntPtr genderArray;
            public int num;
        }
        
        public struct ASF_Face3DAngle
        {
            public IntPtr roll;
            public IntPtr yaw;
            public IntPtr pitch;
            public IntPtr status;
            public int num;
        }
        public struct ASF_LivenessThreshold
        {
            public float thresholdmodel_BGR;
            public float thresholdmodel_IR;
        }
        public struct ASF_LivenessInfo
        {
            public IntPtr isLive; //0:非真人；1：真人；-1不确定；-2人脸个数大于1
            public int num;
        }

        public struct ASVLOFFSCREEN
        {
            public uint u32PixelArrayFormat;
            public int i32Width;
            public int i32Height;
            public IntPtr ppu8Plane;
            public IntPtr pi32Pitch;
        }
        
        public enum ASF_DetectMode
        {
            ASF_DETECT_MODE_VIDEO = 0x00000000, //VIDEO模式，一般用于多帧连续检测
            ASF_DETECT_MODE_IMAGE = 1 //IMAGE模式，一般用于静态图的单次检测
        }

        public enum ArcSoftFace_OrientPriority
        {
            ASF_0P_0_ONLY = 0x1,
            ASF_0P_90_ONLY = 0x2,
            ASF_OP_270_ONLY = 0x3, // 基于0°逆时针旋转270°的方向
            ASF_OP_180_ONLY = 0x4, // 基于0°旋转180°的方向（逆时针、顺时针效果一样）
            ASF_OP_ALL_OUT = 0x5 // 全角度
        }
        
        public enum ArcSoftFace_OrientCode 
        { 
            ASF_OC_0 = 0x1, // 0度
            ASF_OC_90 = 0x2, // 90度
            ASF_OC_270 = 0x3, // 270度
            ASF_OC_180 = 0x4, // 180度
            ASF_OC_30 = 0x5, // 30度
            ASF_OC_60 = 0x6, // 60度
            ASF_OC_120 = 0x7, // 120度
            ASF_OC_150 = 0x8, // 150度
            ASF_OC_210 = 0x9, // 210度
            ASF_OC_240 = 0xa, // 240度
            ASF_OC_300 = 0xb, // 300度
            ASF_OC_330 = 0xc // 330度
        }
        
        public enum ASF_DetectModel
        { 
            ASF_DETECT_MODEL_RGB = 0x1 //RGB图像检测模型 //
                                       //预留扩展其他检测模型
                                       
        }
        
        public enum ASF_CompareModel
        { 
            ASF_LIFE_PHOTO = 0x1, //用于生活照之间的特征比对，推荐阈值0.80
            ASF_ID_PHOTO = 0x2 //用于证件照或生活照与证件照之间的特征比对，推荐阈值0.82
        };
    }

    public struct aaa
    {
        
    }
}