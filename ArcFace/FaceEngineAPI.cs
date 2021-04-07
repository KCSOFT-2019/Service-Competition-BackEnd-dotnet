using System;
using System.Runtime.InteropServices;
using RfidAPI.ArcFace;
namespace RfidAPI.ArcFace
{
    public class FaceEngineAPI
    {
        public static IntPtr hEngine = IntPtr.Zero;

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetActiveFileInfo( IntPtr info);//(ref ArcFaceEngine.ASF_ActiveFileInfo info);

        [DllImport("libarcsoft_face_engine.dll")]
        //public static extern long ASFOnlineActivation(IntPtr AppId, IntPtr SDKKey);
        public static extern long ASFOnlineActivation(string AppId, string SDKKey);

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFInitEngine(
            ArcFaceEngine.ASF_DetectMode asfDetectMode,
            ArcFaceEngine.ArcSoftFace_OrientPriority arcSoftFaceOrientPriority,
            int detectFaceScaleVal,
            int detectFaceMaxNum,
            int combinedMask,
            ref IntPtr hEngine
        );
        
        
        [DllImport("libarcsoft_face_engine.dll", CharSet = CharSet.Ansi)]
        public static extern ArcFaceEngine.ASF_VERSION ASFGetVersion();

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFDetectFaces(
            IntPtr hEngine,
            int width,
            int height,
            int format,
            IntPtr imgData,
            IntPtr detectedFaces,//ArcFaceEngine.ASF_MultiFaceInfo
            ArcFaceEngine.ASF_DetectModel detectModel = ArcFaceEngine.ASF_DetectModel.ASF_DETECT_MODEL_RGB

        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFDetectFacesEX(
            IntPtr hEngine,
            IntPtr imgData, // = LPASVLOFFSCREEN = ASVLOFFSCREEN*
            IntPtr detectedFaces,
            ArcFaceEngine.ASF_DetectModel detectModel = ArcFaceEngine.ASF_DetectModel.ASF_DETECT_MODEL_RGB
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFFaceFeatureExtract(
            IntPtr hEngine, //mHandle
            int width,
            int height,
            int format,
            IntPtr imgData,
            IntPtr faceInfo, //ArcFaceEngine.ASF_SingleFaceInfo*
            ref IntPtr feature //ArcFaceEngine.ASF_FaceFeature*
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFFaceFeatureExtractEx(
            IntPtr hEngine,
            IntPtr imgData,
            IntPtr faceInfo,
            ref IntPtr feature
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFFaceFeatureCompare(
            IntPtr hEngine,
            IntPtr feature1,
            IntPtr feature2,
            ref IntPtr confidenceLevel,
            ArcFaceEngine.ASF_CompareModel compareModel = ArcFaceEngine.ASF_CompareModel.ASF_LIFE_PHOTO
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFSetLivenessParam(
            IntPtr hEngine,
            IntPtr threshold //ArcFaceEngine.ASF_LivenessThreshold *
        );

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFProcess(
            IntPtr hEngine,
            int width,
            int height,
            int format,
            IntPtr imgData,
            IntPtr detectedFaces,
            int combinedMask
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFProcessEx(
            IntPtr hEngine,
            IntPtr imgData,
            IntPtr detectedFaces,
            int combinedMask
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetAge(
            IntPtr hEngine,
            ref IntPtr ageInfo
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetGender(
            IntPtr hEngine,
            ref IntPtr genderInfo
            );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetFace3DAngle(
            IntPtr hEngine,
            ref IntPtr p3DAngleInfo
        );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetLivenessScore(
            IntPtr hEngine,
            ref IntPtr livenessInfo
            );
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFProcess_IR(
            IntPtr hEngine,
            int width,
            int height,
            int format,
            IntPtr imgData,
            IntPtr detectedFaces,
            int combinedMask
            );

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFProcessEx_IR(
            IntPtr hEngine,
            IntPtr imgData,
            IntPtr detectedFaces,
            int combinedMask
            );

        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFUninitEngine(///NO USING !
            IntPtr hEngine
            );
    }

   
}