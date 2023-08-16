using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class UploadRegistrationResponse
{
    [JsonPropertyName("value")]
    public Value Value { get; set; }
}