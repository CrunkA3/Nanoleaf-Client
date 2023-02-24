using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Saturation
{
    internal class IncrementSaturationModel
    {
        public IncrementSaturationModel(int increment) => Increment = new IncrementValue(increment);

        [JsonPropertyName("sat")]
        public IncrementValue Increment { get; set; }
    }
}