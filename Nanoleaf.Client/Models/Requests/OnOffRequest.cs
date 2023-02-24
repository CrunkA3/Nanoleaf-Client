using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class OnOffRequest
    {
        public OnOffRequest(bool value) => Value = new BoolValue(value);

        [JsonPropertyName("on")]
        public BoolValue Value { get; }
    }
}