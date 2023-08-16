using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class ProfilePicture
{
    [JsonPropertyName("displayImage")]
    public string DisplayImage { get; set; }
}