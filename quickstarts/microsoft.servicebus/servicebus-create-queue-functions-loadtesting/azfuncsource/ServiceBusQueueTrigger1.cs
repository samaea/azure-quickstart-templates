using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusProcess
{
    public class ServiceBusQueueTrigger1
    {
        [FunctionName("ServiceBusQueueTrigger1")]
        public void Run([ServiceBusTrigger("myqueue", Connection = "sotmessagesns_SERVICEBUS")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
