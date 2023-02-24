using System.Text.Json.Serialization;

namespace Nanoleaf.Client.Models.Responses
{
    /// <inheritdoc/>
    public class UserToken
    {

        /// <inheritdoc/>
        [JsonPropertyName("auth_token")]
        public string Token { get; set; }
    }
}