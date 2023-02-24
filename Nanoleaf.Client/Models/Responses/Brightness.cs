using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{

    /// <summary>
    /// vrightness state of the device
    /// </summary>
    public class Brightness
    {
        /// <summary>
        /// current brightness of the device
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; }


        /// <summary>
        /// maximum brightness of the device
        /// </summary>
        [JsonPropertyName("max")]
        public int Maximum { get; set; }

        /// <summary>
        /// minimum brightness of the device
        /// </summary>
        [JsonPropertyName("min")]
        public int Minimum { get; set; }
    }
}