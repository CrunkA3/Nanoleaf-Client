using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class IncrementValue
    {
        public IncrementValue(int value) => Value = value;

        [JsonPropertyName("increment")]
        public int Value { get; }
    }
}