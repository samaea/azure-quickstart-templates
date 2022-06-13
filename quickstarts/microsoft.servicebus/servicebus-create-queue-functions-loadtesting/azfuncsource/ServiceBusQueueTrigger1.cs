using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusProcess
{
    public static class ServiceBusTrigger
{
    [FunctionName("ServiceBusQueueTrigger1")]
    public static void Run([ServiceBusTrigger("myqueue", 
        Connection = "ServiceBusConnection")]string myQueueItem, ILogger log)
    {
        log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
    }
}
}
