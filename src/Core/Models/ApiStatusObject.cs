﻿namespace Core.Models
{
    public interface IApiStatusObject
    {
        string Version { get; set; }

        IEnumerable<IssueIndicatorObject> IssueIndicators { get; set; }

        string Env { get; set; }
    }

    //{"Version":"1.45.2855.0","Env":"slot=A"}
    public class ApiStatusObject : IApiStatusObject
    {
        public string Version { get; set; }

        /// <summary>
        /// Issue indicators by service self-control
        /// </summary>
        public IEnumerable<IssueIndicatorObject> IssueIndicators { get; set; }

        public string Env { get; set; }
    }
}
