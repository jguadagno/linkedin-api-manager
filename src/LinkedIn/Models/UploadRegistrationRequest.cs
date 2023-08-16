using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class UploadRegistrationRequest
{
    [JsonPropertyName("registerUploadRequest")]
    public RegisterUploadRequest RegisterUploadRequest { get; set; }
}