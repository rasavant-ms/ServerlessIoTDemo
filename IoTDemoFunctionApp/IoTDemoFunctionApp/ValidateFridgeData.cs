using Microsoft.Azure.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Text;

namespace IoTDemoFunctionApp
{
    public static class ValidateFridgeData
    {
        [FunctionName("ValidateFridgeData")]
        public static void Run([EventHubTrigger("device1", Connection = "receiverConnectionString")]EventData myEventHubMessage, ILogger log)
        {
            log.LogInformation($"C# Event Hub trigger function processed a message: {Encoding.UTF8.GetString(myEventHubMessage.Body.Array)}");
        }
    }
}
