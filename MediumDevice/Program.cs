using MediumDevice.Services;
using Newtonsoft.Json;

var device = new DeviceManager("HostName=elliot-iothub.azure-devices.net;DeviceId=medium_device;SharedAccessKey=zSjj//YpKBroEj6bC17/cxKZooPGMeYE3HynrKr4FjM=");
await device.StartAsync();