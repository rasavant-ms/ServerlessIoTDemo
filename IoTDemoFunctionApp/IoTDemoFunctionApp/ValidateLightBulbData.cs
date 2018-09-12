using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace IoTDemoFunctionApp
{
    public static class ValidateLightBulbData
    {
        [FunctionName("ValidateLightBulbData")]
        public static void Run([EventHubTrigger("device2", Connection = "receiverConnectionString")]string myEventHubMessage, ILogger log)
        {
            log.LogInformation($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}
