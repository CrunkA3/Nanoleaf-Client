using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class IntDurationValue
    {
        public IntDurationValue(int value, int duration)
        {
            Value = value;
            Duration = duration;
        }

        [JsonPropertyName("value")]
        public int Value { get; }

        [JsonPropertyName("duration")]
        public int Duration { get; }
    }
}