using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class EmbedField
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("inline")]
        public bool Inline { get; set; }
    }
}

