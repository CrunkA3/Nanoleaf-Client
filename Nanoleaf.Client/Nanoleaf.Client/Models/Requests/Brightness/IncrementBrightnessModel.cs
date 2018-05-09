﻿using Newtonsoft.Json;

namespace Nanoleaf.Client.Models.Requests.Brightness
{
    [JsonObject(Title = "brightness")]

    public class IncrementBrightnessModel
    {
        public IncrementBrightnessModel(int increment)
        {
            Increment = increment;
        }

        [JsonProperty("increment")]
        public int Increment { get; set; }
    }
}