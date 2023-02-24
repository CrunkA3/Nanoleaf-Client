using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class IntValue
    {
        public IntValue(int value) => Value = value;

        [JsonPropertyName("value")]
        public int Value { get; }
    }
}