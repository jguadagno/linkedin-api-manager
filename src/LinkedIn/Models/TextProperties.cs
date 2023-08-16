﻿using System.Text.Json.Serialization;

namespace LinkedIn.Models;

/// <summary>
/// Sets the text for the title or description
/// </summary>
public class TextProperties
{
    /// <summary>
    /// Sets the text for the title or description
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }
}