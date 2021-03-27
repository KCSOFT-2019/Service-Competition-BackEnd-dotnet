using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Mvc;
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
    }
}