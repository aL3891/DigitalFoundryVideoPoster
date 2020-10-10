using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    public class Embed
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; } = "rich";
        [JsonPropertyName("description")]
        public string Description { get; set; }
        public string Url { get; set; }
        [JsonPropertyName("timestamp")]
        public DateTimeOffset? TimeStamp { get; set; }
        [JsonPropertyName("color")]
        public int Color { get; set; }
        [JsonPropertyName("footer")]
        public EmbedFooter Footer { get; set; }
        [JsonPropertyName("image")]
        public EmbedImage Image { get; set; }
        [JsonPropertyName("thumbnail")]
        public EmbedThumbnail Thumbnail { get; set; }
        [JsonPropertyName("video")]
        public EmbedVideo Video { get; set; }
        [JsonPropertyName("provider")]
        public EmbedProvider Provider { get; set; }
        [JsonPropertyName("author")]
        public EmbedAuthor Author { get; set; }
        [JsonPropertyName("fields")]
        public List<EmbedField> Fields { get; set; } = new List<EmbedField>();
    }
}

