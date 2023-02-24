using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class Switch
    {
        [JsonPropertyName("value")]
        public bool Power { get; set; }
    }
}