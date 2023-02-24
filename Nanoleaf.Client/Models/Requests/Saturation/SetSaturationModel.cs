using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Saturation
{
    internal class SetSaturationModel
    {
        public SetSaturationModel(int value) => Value = new IntValue(value);

        [JsonPropertyName("sat")]
        public IntValue Value { get; set; }
    }
}