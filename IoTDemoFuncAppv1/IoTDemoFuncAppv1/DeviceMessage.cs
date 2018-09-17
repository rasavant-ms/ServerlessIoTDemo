using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDemoFuncAppv1
{
    public class DeviceMessage
    {
        [JsonProperty("temperature")]
        public int Temperature { get; set; }
        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
