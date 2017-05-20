// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MonitoringServiceApiCaller.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MonitoringObjectPingModel
    {
        /// <summary>
        /// Initializes a new instance of the MonitoringObjectPingModel class.
        /// </summary>
        public MonitoringObjectPingModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitoringObjectPingModel class.
        /// </summary>
        public MonitoringObjectPingModel(string serviceName = default(string), string version = default(string), System.DateTime? skipUntil = default(System.DateTime?))
        {
            ServiceName = serviceName;
            Version = version;
            SkipUntil = skipUntil;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipUntil")]
        public System.DateTime? SkipUntil { get; set; }

    }
}
