using System;
using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Requests.Effects
{
    public class SelectEternalModel
    {
        public SelectEternalModel()
        {
            write = new Write { Command = "display", AnimationType = "extControl" };
        }


        /// <summary>
        /// Write command
        /// </summary>
        [JsonPropertyName("write")]
        public Write write;

        [Serializable]
        public class Write
        {
            [JsonPropertyName("command")]
            public string Command;

            [JsonPropertyName("animType")]
            public string AnimationType;
        }
    }
}