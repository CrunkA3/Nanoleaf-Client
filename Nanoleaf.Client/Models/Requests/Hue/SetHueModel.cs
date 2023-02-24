using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Hue
{
    internal class SetHueModel
    {
        public SetHueModel(int value) => Value = new IntValue(value);

        [JsonPropertyName("hue")]
        public IntValue Value { get; set; }
    }
}