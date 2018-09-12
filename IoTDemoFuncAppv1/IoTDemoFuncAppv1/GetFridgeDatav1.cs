using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;

namespace IoTDemoFuncAppv1
{
    public static class GetFridgeDatav1
    {
        [FunctionName("GetFridgeDatav1")]
        public static void Run([EventHubTrigger("device1", Connection = "receiverConnectionString")]string myEventHubMessage, TraceWriter log)
        {
            log.Info($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}
