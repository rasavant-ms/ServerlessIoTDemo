using IoTHubTrigger = Microsoft.Azure.WebJobs.ServiceBus.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace IoTDemoFuncAppv1
{
    public static class Function1
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("Function1")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "receiverConnectionString")]EventData message, ILogger log)
        {
            string deviceMsgData = Encoding.UTF8.GetString(message.GetBytes());
            log.LogInformation($"C# IoT Hub trigger function processed a message: {deviceMsgData}");

            

            DeviceMessage deviceMessage = JsonConvert.DeserializeObject<DeviceMessage>(deviceMsgData);


            if(deviceMessage.DeviceType == "LightBulb" && deviceMessage.State == "off")
            {
                log.LogError("The light bulb is off !");
            }

            //if(deviceMessage.DeviceType == "Fridge" && deviceMessage.Temperature >)
            //log.LogInformation($"C# messageObject is  {deviceMessage}");
        }
    }
}