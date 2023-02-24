using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class PowerStatus
    {
        [JsonPropertyName("value")]
        public bool Value { get; set; }
    }
}
