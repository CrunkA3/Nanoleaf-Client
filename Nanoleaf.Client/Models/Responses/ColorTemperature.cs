using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    /// <summary>
    /// color temperature response
    /// </summary>
    public class ColorTemperature
    {
        /// <summary>
        /// current color termperature (Kelvin)
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; }


        /// <summary>
        /// maximum color termperature (Kelvin)
        /// </summary>
        [JsonPropertyName("max")]
        public int Maximum { get; set; }


        /// <summary>
        /// minimum color termperature (Kelvin)
        /// </summary>
        [JsonPropertyName("min")]
        public int Minimum { get; set; }
    }
}