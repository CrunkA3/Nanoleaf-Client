using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class Info
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("serialNo")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("state")]
        public State State { get; set; }

        [JsonPropertyName("effects")]
        public Effects Effects { get; set; }
    }
}