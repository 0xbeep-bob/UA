using DeviceDetectorNET.Results;
using DeviceDetectorNET.Results.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace UA.Models
{
    public class ParsedUA
    {
        public ParsedUA()
        {
            Device = new Device();
        }

        public ClientMatchResult Client { get; set; }
        public OsMatchResult Os { get; set; }
        public Device Device { get; set; }
        public bool IsBot { get; set; }
        public BotMatchResult Bot { get; set; }
    }

    public class Device
    {
        public string DeviceName { get; set; }
        public string Model { get; set; }
        public bool IsDesktop { get; set; }
        public bool IsMobile { get; set; }
    }
}
