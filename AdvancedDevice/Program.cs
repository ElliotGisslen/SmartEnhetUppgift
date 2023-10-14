using AdvancedDevice.Services;

var device = new DeviceManager("HostName=elliot-iothub.azure-devices.net;DeviceId=advanced_device;SharedAccessKey=FB43E6wJXR9c2IEQlkLGr0QgXR7LQTgHuuX1JRMRcb4=");
device.Start();

Console.WriteLine("Press [Enter] to close application.");
Console.ReadKey();








