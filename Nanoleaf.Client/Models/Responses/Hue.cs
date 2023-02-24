using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class Hue
    {
        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("max")]
        public int Maximum { get; set; }

        [JsonPropertyName("min")]
        public int Minimum { get; set; }
    }
}