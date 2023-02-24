using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Brightness
{
    internal class IncrementBrightnessModel
    {
        public IncrementBrightnessModel(int increment) => Increment = new IncrementValue(increment);

        [JsonPropertyName("increment")]
        public IncrementValue Increment { get; set; }
    }
}