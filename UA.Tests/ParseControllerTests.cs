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
        [Fact]
        public void UADeviceIsDesktop()
        {
            ParseController parseCRL = new ParseController();

            var result = parseCRL.ParseUa(""); // пусто за отсутствием логики парсинга

            Assert.True(result.Device.IsDesktop);
        }

        [Fact]
        public void UADeviceIsMobile()
        {
            ParseController parseCRL = new ParseController();

            var result = parseCRL.ParseUa(""); // пусто за отсутствием логики парсинга

            Assert.True(result.Device.IsMobile);
        }

        [Fact]
        public void UAClientIsBot()
        {
            ParseController parseCRL = new ParseController();

            var result = parseCRL.ParseUa(""); // пусто за отсутствием логики парсинга

            Assert.True(result.Client.Bot);
        }
    }
}
