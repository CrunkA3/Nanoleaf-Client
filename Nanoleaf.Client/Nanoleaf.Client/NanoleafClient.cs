using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Nanoleaf.Client.Colors;
using Nanoleaf.Client.Interfaces;
using Nanoleaf.Client.Models.Requests;
using Nanoleaf.Client.Models.Requests.Brightness;
using Nanoleaf.Client.Models.Requests.ColorTemperature;
using Nanoleaf.Client.Models.Requests.Effects;
using Nanoleaf.Client.Models.Requests.Hue;
using Nanoleaf.Client.Models.Requests.Saturation;
using Nanoleaf.Client.Models.Responses;

namespace Nanoleaf.Client
{
    /// <inheritdoc/>
    public class NanoleafClient : INanoleafClient
    {
        private bool _isDisposed;
        private readonly NanoleafHttpClient _nanoleafHttpClient;
        /// <summary>
        /// Allow us to retrieve the device hostname for later
        /// </summary>
        public string HostName { get; }

        /// <summary>
        /// Create a new nanoleaf client
        /// </summary>
        /// <param name="host">Hostname or IP address of nanoleaf device</param>
        /// <param name="userToken">(Optional) User token to use if authorized</param>
        /// <param name="client">(Optional) Used to pass a shared HttpClient</param>
        public NanoleafClient(string host, string userToken = "", HttpClient client = null)
        {
            _nanoleafHttpClient = new NanoleafHttpClient(host, userToken, client);
            HostName = host;
        }

        /// <inheritdoc/>
        public void Authorize(string token)
        {
            _nanoleafHttpClient.AuthorizeRequests(token);
        }

        /// <inheritdoc/>
        public Task<Info> GetInfoAsync() => _nanoleafHttpClient.SendGetRequest<Info>();

        /// <summary>
        /// Retrieves the current panel layout.
        /// Requires authorization.
        /// </summary>
        /// <returns></returns>
        public Task<Layout> GetLayoutAsync() => _nanoleafHttpClient.SendGetRequest<Layout>("panelLayout/layout");


        #region User

        /// <summary>
        /// Attempt to create a new user token object.
        /// </summary>
        /// <returns>New user token</returns>
        public Task<UserToken> CreateTokenAsync() => _nanoleafHttpClient.AddUserRequestAsync();

        /// <summary>Deletes the token asynchronous.</summary>
        /// <param name="userToken">The user token.</param>
        public async Task DeleteTokenAsync(string userToken)
        {
            await _nanoleafHttpClient.DeleteUserRequest(userToken + "/");
        }

        #endregion

        #region Power

        /// <inheritdoc/>
        public async Task<bool> GetPowerStatusAsync()
        {
            var response = await _nanoleafHttpClient.SendGetRequest<PowerStatus>("state/on");
            return response.Value;
        }


        /// <inheritdoc/>
        public async Task TurnOnAsync()
        {
            var request = new OnOffRequest(true);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task TurnOffAsync()
        {
            var request = new OnOffRequest(false);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        #endregion

        #region Brightness

        /// <inheritdoc/>
        public Task<Brightness> GetBrightnessInfoAsync() => _nanoleafHttpClient.SendGetRequest<Brightness>("state/brightness");

        /// <inheritdoc/>
        public Task<int> GetBrightnessAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/brightness/value");


        /// <inheritdoc/>
        public Task<int> GetBrightnessMaxValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/brightness/max");

        /// <inheritdoc/>
        public Task<int> GetBrightnessMinValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/brightness/min");

        /// <inheritdoc/>
        public async Task SetBrightnessAsync(int targetBrightness, int time = 0)
        {
            var request = new SetBrightnessModel(targetBrightness, time);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task RaiseBrightnessAsync(int value)
        {
            var request = new IncrementBrightnessModel(value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task LowerBrightnessAsync(int value)
        {
            var request = new IncrementBrightnessModel(-value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        #endregion

        #region Hue

        /// <inheritdoc/>
        public Task<Hue> GetHueInfoAsync() => _nanoleafHttpClient.SendGetRequest<Hue>("state/hue");

        /// <inheritdoc/>
        public Task<int> GetHueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/hue/value");
        /// <inheritdoc/>
        public Task<int> GetHueMaxValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/hue/max");
        /// <inheritdoc/>
        public Task<int> GetHueMinValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/hue/min");


        /// <inheritdoc/>
        public async Task SetHueAsync(int targetHue)
        {
            var request = new SetHueModel(targetHue);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task RaiseHueAsync(int value)
        {
            var request = new IncrementHueModel(value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task LowerHueAsync(int value)
        {
            var request = new IncrementHueModel(-value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        #endregion

        #region Saturation

        /// <inheritdoc/>
        public Task<Saturation> GetSaturationInfoAsync() => _nanoleafHttpClient.SendGetRequest<Saturation>("state/sat");

        /// <inheritdoc/>
        public Task<int> GetSaturationAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/sat/value");

        /// <inheritdoc/>
        public Task<int> GetSaturationMaxValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/sat/max");

        /// <inheritdoc/>
        public Task<int> GetSaturationMinValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/sat/min");

        /// <inheritdoc/>
        public async Task SetSaturationAsync(int targetSat)
        {
            var request = new SetSaturationModel(targetSat);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task RaiseSaturationAsync(int value)
        {
            var request = new IncrementSaturationModel(value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task LowerSaturationAsync(int value)
        {
            var request = new IncrementSaturationModel(-value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        #endregion

        #region Color Temperature

        /// <inheritdoc/>
        public Task<ColorTemperature> GetTemperatureInfoAsync() => _nanoleafHttpClient.SendGetRequest<ColorTemperature>("state/ct");

        /// <inheritdoc/>
        public Task<int> GetColorTemperatureAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/ct/value");

        /// <inheritdoc/>
        public Task<int> GetColorTemperatureMaxValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/ct/max");
        /// <inheritdoc/>
        public Task<int> GetColorTemperatureMinValueAsync() => _nanoleafHttpClient.SendGetRequest<int>("state/ct/min");


        /// <inheritdoc/>
        public async Task SetColorTemperatureAsync(int targetCt)
        {
            var request = new SetColorTemperatureModel(targetCt);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task RaiseColorTemperatureAsync(int value)
        {
            var request = new IncrementColorTemperatureModel(value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task LowerColorTemperatureAsync(int value)
        {
            var request = new IncrementColorTemperatureModel(-value);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        #endregion

        #region Effects

        /// <inheritdoc/>
        public Task<string> GetCurrentEffectAsync() => _nanoleafHttpClient.SendGetRequest<string>("effects/select");

        /// <inheritdoc/>
        public Task<List<string>> GetEffectsAsync() => _nanoleafHttpClient.SendGetRequest<List<string>>("effects/effectsList");

        /// <inheritdoc/>
        public async Task SetEffectAsync(string effectName)
        {
            var request = new SelectEffectModel(effectName);
            await _nanoleafHttpClient.SendPutRequest(request, "effects/");
        }

        // public async Task StartExternalAsync(string version = "v2")
        // {
        //     var request = new SelectEternalModel(version);
        //     await _nanoleafHttpClient.SendPutRequest(request, "effects/");
        // }



        #endregion

        /// <inheritdoc/>
        public Task<string> GetColorModeAsync() => _nanoleafHttpClient.SendGetRequest<string>("state/colorMode");

        /// <inheritdoc/>
        public async Task SetHsvAsync(int h, int s, int v)
        {
            var request = new HsvRequest(h, s, v);
            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        public async Task SetRgbAsync(int r, int g, int b)
        {
            var hsv = ColorConverter.RgbToHsv(r, g, b);
            var request = new HsvRequest(hsv.H, hsv.S, hsv.V);

            await _nanoleafHttpClient.SendPutRequest(request, "state/");
        }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _nanoleafHttpClient.Dispose();
                }

                _isDisposed = true;
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}