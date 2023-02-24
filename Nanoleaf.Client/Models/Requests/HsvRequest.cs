using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests
{
    internal class HsvRequest
    {
        [JsonPropertyName("hue")]
        public int H { get; set; }

        [JsonPropertyName("sat")]
        public int S { get; set; }

        [JsonPropertyName("brightness")]
        public int V { get; set; }

        public HsvRequest(int h, int s, int v)
        {
            H = h;
            S = s;
            V = v;
        }
    }
}