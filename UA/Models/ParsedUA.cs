using System;
using System.Collections.Generic;
using System.Text;

namespace UA.Models
{
    public class ParsedUA
    {
        public string ClientSummary { get; set; }
        public string UaFamily { get; set; }
        public string UaType { get; set; }
        public UaVersion UaVersion { get; set; }
        public string OsFamily { get; set; }
        public OsVersion OsVersion { get; set; }
        public BotInfo BotInfo { get; set; }
        public OsMeta OsMeta { get; set; }
        public string UaRenderingEngine { get; set; }
        public UaRenderingEngineVersion UaRenderingEngineVersion { get; set; }
        public Device Device { get; set; }
        public Client Client { get; set; }
    }

    public class UaVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public string Summary { get; set; }
    }

    public class OsVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public string Summary { get; set; }
    }

    public class Vendor
    {
        public object Name { get; set; }
        public object Url { get; set; }
    }

    public class BotInfo
    {
        public object Name { get; set; }
        public object Category { get; set; }
        public object Url { get; set; }
        public Vendor Vendor { get; set; }
    }

    public class OsMeta
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Version { get; set; }
        public object Platform { get; set; }
    }

    public class UaRenderingEngineVersion
    {
        public string Major { get; set; }
        public string Minor { get; set; }
        public string Patch { get; set; }
        public string Summary { get; set; }
    }

    public class Device
    {
        public bool IsMobile { get; set; }
        public bool IsTablet { get; set; }
        public bool IsDesktop { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    public class Client
    {
        public bool Bot { get; set; }
        public bool User { get; set; }
    }
}
