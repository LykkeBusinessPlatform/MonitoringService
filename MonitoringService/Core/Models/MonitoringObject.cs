﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public interface IMonitoringObject
    {
        string ServiceName { get; set; }
        string Version { get; set; }
        DateTime LastTime { get; set; }
        DateTime? SkipCheckUntil { get; set; }
        string Url { get; set; }
    }

    public class MonitoringObject : IMonitoringObject
    {
        public string ServiceName{ get; set; }
        public string Version { get; set; }
        public DateTime LastTime { get; set; }
        public DateTime? SkipCheckUntil { get; set; }
        public string Url { get; set; }
    }
}
