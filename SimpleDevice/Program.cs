using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System.Text;

DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=elliot-iothub.azure-devices.net;DeviceId=simple_device;SharedAccessKey=T/f65xhuO7ff+Lptmsxe1z5KMbyPxCZUUKUSLPhKWd8=", TransportType.Mqtt);




var data = new
{
    Message = "Mitt meddelende",
    Created = DateTime.Now
};


await SendTelemetryAsync(JsonConvert.SerializeObject(data));    





async Task SendTelemetryAsync(string payloadAsJson)
{
    while(true)
    {
        var message = new Message(Encoding.UTF8.GetBytes(payloadAsJson));
        await deviceClient.SendEventAsync(message);

        Console.WriteLine($"Message sent at {DateTime.Now} with payload {payloadAsJson}"); 

        await Task.Delay(5000);
    }

}