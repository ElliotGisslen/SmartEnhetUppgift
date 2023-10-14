using System;
using System.Diagnostics.Tracing;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace AzureFunctions
{
    public class ViewMessages
    {
        private readonly ILogger<ViewMessages> _logger;

        public ViewMessages(ILogger<ViewMessages> logger)
        {
            _logger = logger;
        }

        [Function("ViewMessages")]
        public void Run([EventHubTrigger("iothub-ehub-elliot-iot-25234255-8916e93e4b", Connection = "IotHubEndpoint")] string[] input)
        {
            foreach (EventData @event in events)
            {

            }
        }
    }
}
