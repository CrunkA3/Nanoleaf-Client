using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Hue
{
    internal class IncrementHueModel
    {
        public IncrementHueModel(int increment) => Increment = new IncrementValue(increment);

        [JsonPropertyName("hue")]
        public IncrementValue Increment { get; set; }
    }
}