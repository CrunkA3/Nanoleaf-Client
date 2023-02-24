using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    /// <summary>
    /// Device Informations
    /// </summary>
    public class Info
    {
        /// <summary>
        /// Device name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Serial number
        /// </summary>
        [JsonPropertyName("serialNo")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Manufacturer of the device
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Firmware version
        /// </summary>
        [JsonPropertyName("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }

        /// <summary>
        /// Device state
        /// </summary>
        [JsonPropertyName("state")]
        public State State { get; set; }

        /// <summary>
        /// Effect informations
        /// </summary>
        [JsonPropertyName("effects")]
        public Effects Effects { get; set; }
    }
}