using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Brightness
{
    internal class SetBrightnessModel
    {
        public SetBrightnessModel(int value, int duration) => Brightness = new IntDurationValue(value, duration);

        [JsonPropertyName("brightness")]
        public IntDurationValue Brightness { get; set; }
    }
}