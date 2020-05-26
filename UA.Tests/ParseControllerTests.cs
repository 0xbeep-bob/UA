using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using UA.Controllers;
using UA.Models;
using Xunit;

namespace UA.Tests
{
    public class ParseControllerTests
    {
        [Theory]
        [InlineData("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:76.0) Gecko/20100101 Firefox/76.0")]
        public void UADeviceIsDesktop(string ua)
        {
            ParseController parseCRL = new ParseController();
            parseCRL.SetUA(ua);

            var result = parseCRL.ParseUA();

            Assert.True(result.Device.IsDesktop);
        }

        [Theory]
        [InlineData("Mozilla/5.0 (Android 10.0; Mobile; rv:68.0) Gecko/68.0 Firefox/68.0")]
        public void UADeviceIsMobile(string ua)
        {
            ParseController parseCRL = new ParseController();
            parseCRL.SetUA(ua);

            var result = parseCRL.ParseUA();

            Assert.True(result.Device.IsMobile);
        }

        [Theory]
        [InlineData("Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)")]
        public void UAClientIsBot(string ua)
        {
            ParseController parseCRL = new ParseController();
            parseCRL.SetUA(ua);

            var result = parseCRL.ParseUA();

            Assert.True(result.IsBot);
        }
    }
}
