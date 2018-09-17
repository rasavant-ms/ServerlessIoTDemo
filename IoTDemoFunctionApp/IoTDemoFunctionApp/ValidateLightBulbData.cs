using Microsoft.Azure.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace IoTDemoFunctionApp
{
    public static class ValidateLightBulbData
    {
        [FunctionName("ValidateLightBulbData")]
        public static void Run([EventHubTrigger("lightbulbdevices", Connection = "receiverConnectionString")]EventData myEventHubMessage, ILogger log)
        {
            log.LogInformation($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}
