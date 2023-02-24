using System;
using DeviceDiscovery.Models;
using Nanoleaf.Client;
using Nanoleaf.Client.Discovery;
using Microsoft.Extensions.Configuration;


namespace Nanoleaf.Test
{
    class Program
    {
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();


            //var request = new NanoleafDiscoveryRequest
            //{
            //    ST = SearchTarget.Nanoleaf
            //};

            //using (var nanoleafDiscovery = new NanoleafDiscovery())
            //{
            //    var discoveredNanoleafs = nanoleafDiscovery.DiscoverNanoleafs(request);
            //    var nanoleaf = discoveredNanoleafs.FirstOrDefault();
            //    nanoleaf?.Authorize("qEQ8ZLcPuOVesarDXIW6eGQQd1Hhn1d9");

            //    var status = nanoleaf.GetPowerStatusAsync().Result;

            //    if (status)
            //    {
            //        nanoleaf.TurnOffAsync().Wait(1000);
            //    }
            //    else
            //    {
            //        nanoleaf.TurnOnAsync().Wait(1000);
            //    }
            //}


            var ip = config["DeviceIp"];
            var token = config["AuthToken"];

            using (var client = new NanoleafClient(ip, token))
            {
                var res = client.GetInfoAsync().Result;
                Console.WriteLine($"Test for {client.HostName}: " + res.State.Switch.Power);
            }

            //Console.ReadKey();
        }
    }
}