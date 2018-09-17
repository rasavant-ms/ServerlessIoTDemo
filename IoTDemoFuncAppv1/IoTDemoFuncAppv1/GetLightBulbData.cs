using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;

namespace IoTDemoFuncAppv1
{
    public static class GetLightBulbData
    {
        //[FunctionName("GetLightBulbData")]
        //public static void Run([EventHubTrigger("device2", Connection = "receiverConnectionString", ConsumerGroup = "bulbconsumer")]string myEventHubMessage, TraceWriter log)
        //{
        //    log.Info($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        //}
    }
}
