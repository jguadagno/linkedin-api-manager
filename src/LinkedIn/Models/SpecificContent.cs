using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class SpecificContent
{
    [JsonPropertyName("com.linkedin.ugc.ShareContent")]
    public ShareContent ShareContent { get; set; }
}