using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class State
    {
        [JsonPropertyName("on")]
        public Switch Switch { get; set; }

        [JsonPropertyName("brightness")]
        public Brightness Brightness { get; set; }

        [JsonPropertyName("hue")]
        public Hue Hue { get; set; }

        [JsonPropertyName("sat")]
        public Saturation Saturation { get; set; }

        [JsonPropertyName("ct")]
        public ColorTemperature ColorTemperature { get; set; }

        [JsonPropertyName("effect")]
        public string ColorMode { get; set; }
    }
}