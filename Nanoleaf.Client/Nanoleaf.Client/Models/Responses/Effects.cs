using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    public class Effects
    {
        [JsonPropertyName("select")]
        public string SelectedEffect { get; set; }

        [JsonPropertyName("effectsList")]
        public List<string> EffectList { get; set; }
    }
}