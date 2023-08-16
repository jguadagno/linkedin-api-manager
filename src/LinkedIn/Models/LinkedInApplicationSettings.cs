namespace LinkedIn.Models;

public class LinkedInApplicationSettings : ILinkedInApplicationSettings
{
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public string? AccessToken { get; set; }
    public string? AuthorId { get; set; }
}