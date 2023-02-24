using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class BoolValue
    {
        public BoolValue(bool value) => Value = value;

        [JsonPropertyName("value")]
        public bool Value { get; }
    }
}