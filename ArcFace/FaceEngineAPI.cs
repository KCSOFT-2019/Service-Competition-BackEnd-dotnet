using System;
using System.Runtime.InteropServices;
using RfidAPI.ArcFace;
namespace RfidAPI.ArcFace
{
    public class FaceEngineAPI
    {
        public static IntPtr hEngine = IntPtr.Zero;
        [DllImport("libarcsoft_face_engine.dll")]
        public static extern long ASFGetActiveFileInfo(ArcFaceEngine.ASF_ActiveFileInfo asfActiveFileInfo);

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
    }

   
}