using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.ColorTemperature
{
    internal class IncrementColorTemperatureModel
    {
        public IncrementColorTemperatureModel(int increment) => Increment = new IncrementValue(increment);

        [JsonPropertyName("ct")]
        public IncrementValue Increment { get; set; }
    }
}