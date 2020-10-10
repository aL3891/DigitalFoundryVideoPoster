using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class EmbedProvider
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

