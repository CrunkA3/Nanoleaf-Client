﻿using System;
using System.Collections.Generic;
using DeviceDiscovery;
using DeviceDiscovery.Models;

namespace Nanoleaf.Client.Discovery
{
    /// <summary>
    /// Discover Nanoleaf devices
    /// </summary>
    public class NanoleafDiscovery : IDisposable
    {
        private bool _isDisposed;
        private readonly DiscoveryService _discoveryService = new DiscoveryService();

        /// <summary>
        /// Discovered nanoleaf devices
        /// </summary>
        public List<NanoleafClient> NanoleafClients { get; } = new List<NanoleafClient>();

        /// <summary>
        /// Call this method to discover devices
        /// </summary>
        /// <param name="discoveryRequest"></param>
        /// <returns></returns>
        public List<NanoleafClient> DiscoverNanoleafs(NanoleafDiscoveryRequest discoveryRequest)
        {
            var nanoleafDevices = _discoveryService.LocateDevices(discoveryRequest);

            NanoleafClients.Clear();

            foreach (MSearchResponse device in nanoleafDevices)
            {
                NanoleafClients.Add(new NanoleafClient(device.Location.Host));
            }

            return NanoleafClients;
        }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    foreach (var nanoleaf in NanoleafClients)
                    {
                        nanoleaf.Dispose();
                    }
                }

                _isDisposed = true;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(true);
        }
    }
}