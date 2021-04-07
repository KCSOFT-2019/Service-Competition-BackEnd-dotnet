using System;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using RfidAPI.ArcFace;
using RfidAPI.Models;


namespace RfidAPI.Controllers
{
    [Route("ArcFace")]
    public class ArcFaceController
    {
        [HttpGet("version")]
        public ActionResult<string> getVersion()
        {
            try
            {
                var asfversion = FaceEngineAPI.ASFGetVersion();
                return Marshal.PtrToStringAnsi(asfversion.Version);
                
            }
            catch (Exception e)
            {
                
                throw;
            }
            
            //return System.BitConverter.ToString(asfversion.Version);
            /*System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            return ascii.GetString(asfversion.Version);*/
            
            return null;
        }

        [HttpPost("activeOnline")]
        public ActionResult<long> ActiveOnline(string appId, string sdkkey)
        {
            var res = FaceEngineAPI.ASFOnlineActivation(appId, sdkkey);//FaceEngineAPI.ASFOnlineActivation(Marshal.StringToHGlobalAuto(appId), Marshal.StringToHGlobalAuto(sdkkey));
            return res;
        }

        [HttpPost]
        public ActionResult<long> InitEngine(
            ArcFaceEngine.ASF_DetectMode asfDetectMode,
            ArcFaceEngine.ArcSoftFace_OrientPriority arcSoftFaceOrientPriority,
            int detectFaceScaleVal,
            int detectFaceMaxNum,
            int combinedMask)
        {
            //IntPtr handle = IntPtr.Zero;
            var res = FaceEngineAPI.ASFInitEngine(
                asfDetectMode,
                arcSoftFaceOrientPriority,
                detectFaceScaleVal,
                detectFaceMaxNum,
                combinedMask, ref FaceEngineAPI.hEngine);
            return res;
        }
        
        
        /*public ActionResult<long> ASFDetectFaces(IntPtr hEngine,
            int width,
            int height,
            int format,
            IntPtr imgData,
            ArcFaceEngine.ASF_MultiFaceInfo detectedFaces,
            ArcFaceEngine.ASF_DetectModel detectModel = ArcFaceEngine.ASF_DetectModel.ASF_DETECT_MODEL_RGB
        )*/
        [HttpGet("getActiveFileInfo")]
        public ActionResult<string> getActiveFileInfo()
        {
            /*{
                var point = new ArcFaceEngine.ASF_ActiveFileInfo();//IntPtr();
            
                unsafe
                {
                    FaceEngineAPI.ASFGetActiveFileInfo(ref point);
                }
            
                //var info = Marshal.PtrToStructure<ArcFaceEngine.ASF_ActiveFileInfo>(point);
                return Marshal.PtrToStringAnsi(point.sdkVersion);
            }*/


            {
                unsafe
                {


                    IntPtr point = Marshal.AllocCoTaskMem(sizeof(ArcFaceEngine.ASF_ActiveFileInfo));

                    FaceEngineAPI.ASFGetActiveFileInfo(point);

                    var file = (ArcFaceEngine.ASF_ActiveFileInfo) Marshal.PtrToStructure(point, typeof(ArcFaceEngine.ASF_ActiveFileInfo));
                    var sdkver =  Marshal.PtrToStringAnsi(file.sdkVersion);
                    Marshal.FreeCoTaskMem(point);
                    return sdkver;
                    
                }
            }
        }
    }
}