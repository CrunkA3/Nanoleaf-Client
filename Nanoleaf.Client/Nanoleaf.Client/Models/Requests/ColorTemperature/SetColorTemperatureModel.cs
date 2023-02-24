using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.ColorTemperature
{
    internal class SetColorTemperatureModel
    {
        public SetColorTemperatureModel(int value) => Value = new IntValue(value);

        [JsonPropertyName("ct")]
        public IntValue Value { get; set; }
    }
}