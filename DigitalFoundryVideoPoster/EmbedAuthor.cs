using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class EmbedAuthor
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
}

