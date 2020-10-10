using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class DiscordWebhook
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonPropertyName("tts")]
        public bool IsTTS { get; set; }
        [JsonPropertyName("embeds")]
        public List<Embed> Embeds { get; set; } = new List<Embed>();
    }
}

