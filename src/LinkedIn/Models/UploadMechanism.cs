using System.Text.Json.Serialization;

namespace LinkedIn.Models;

public class UploadMechanism
{
    /// <summary>
    /// Details to upload media
    /// </summary>
    [JsonPropertyName("com.linkedin.digitalmedia.uploading.MediaUploadHttpRequest")]
    public MediaUploadHttpRequest MediaUploadHttpRequest { get; set; }
}