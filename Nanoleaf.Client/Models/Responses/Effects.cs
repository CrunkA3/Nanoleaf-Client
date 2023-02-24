using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    /// <summary>
    /// Effect informations
    /// </summary>
    public class Effects
    {
        /// <summary>
        /// The name of the selected effect
        /// </summary>
        [JsonPropertyName("select")]
        public string SelectedEffect { get; set; }

        /// <summary>
        /// List with names of effects
        /// </summary>
        [JsonPropertyName("effectsList")]
        public List<string> EffectList { get; set; }
    }
}