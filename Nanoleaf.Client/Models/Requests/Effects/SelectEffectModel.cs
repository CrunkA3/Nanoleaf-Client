using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Effects
{
    internal class SelectEffectModel
    {
        public SelectEffectModel(string effectName) => EffectName = effectName;

        [JsonPropertyName("select")]
        public string EffectName { get; set; }
    }
}