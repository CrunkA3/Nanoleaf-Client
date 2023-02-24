using System;
using DeviceDiscovery.Models;
using Nanoleaf.Client.Core;

namespace Nanoleaf.Client.Discovery
{
    /// <summary>
    /// Nanoleaf device discovery options
    /// </summary>
    public class NanoleafDiscoveryRequest : MSearchRequest
    {

        /// <summary>
        /// Create a new instance of NanoleafDiscoveryRequest
        /// </summary>
        /// <param name="unicastPort"></param>
        /// <param name="timeoutSeconds"></param>
        public NanoleafDiscoveryRequest(int unicastPort = Constants.DefaultUnicastPort, double timeoutSeconds = 5)
        {
            MulsticastPort = Constants.NanoleafMulticastPort;
            UnicastPort = unicastPort;
            Timeout = TimeSpan.FromSeconds(timeoutSeconds);
        }
    }
}