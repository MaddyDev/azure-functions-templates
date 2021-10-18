using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class ServiceBusTopicTriggerCSharp
    {
        private readonly ILogger<ServiceBusTopicTriggerCSharp> _logger;

        public ServiceBusTopicTriggerCSharp(FunctionContext context)
        {
            _logger = context.GetLogger<ServiceBusTopicTriggerCSharp>();
        }

        [Function("ServiceBusTopicTriggerCSharp")]
        public void Run([ServiceBusTrigger("TopicNameValue", "SubscriptionNameValue", Connection = "ConnectionValue")] string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
