using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class EmbedFooter
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
}

