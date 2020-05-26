using DeviceDetectorNET;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UA.Models;

namespace UA.Controllers
{
    [Route("parse")]
    public class ParseController : Controller
    {
        private string UserAgent { get; set; }

        [HttpGet("ua")]
        public ParsedUA ParseUA()
        {
            string ua;
            if (string.IsNullOrEmpty(UserAgent))
                ua = Request.Headers["User-Agent"].ToString();
            else
                ua = UserAgent;

            ParsedUA result = new ParsedUA();

            var dd = new DeviceDetector(ua);
            dd.Parse();

            if (dd.IsBot())
            {
                result.IsBot = true;
                result.Bot = dd.GetBot().Match;
            }
            else
            {
                result.Client = dd.GetClient().Match;
                result.Os = dd.GetOs().Match;
                result.Device.DeviceName = dd.GetDeviceName();
                result.Device.Model = dd.GetModel();
                result.Device.IsDesktop = dd.IsDesktop();
                result.Device.IsMobile = dd.IsMobile();
            }

            return result;
        }

        public void SetUA(string ua)
        {
            if (!string.IsNullOrEmpty(ua))
                UserAgent = ua;
        }
    }
}
