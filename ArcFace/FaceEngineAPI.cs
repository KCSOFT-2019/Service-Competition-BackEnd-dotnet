using System.Runtime.InteropServices;
using RfidAPI.ArcFace;
namespace RfidAPI.ArcFace
{
    public class FaceEngineAPI
    {
        [DllImport("libarcsoft_face_engine.dll", CharSet = CharSet.Ansi)]
        public static extern ArcFaceEngine.ASF_VERSION ASFGetVersion();
    }

   
}