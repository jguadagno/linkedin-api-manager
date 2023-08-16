using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class PreferredLocale
{
    [JsonPropertyName("country")]
    public string Country { get; set; }
    
    [JsonPropertyName("language")]
    public string Language { get; set; }
}