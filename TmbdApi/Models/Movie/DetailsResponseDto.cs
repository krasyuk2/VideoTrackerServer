namespace TmbdApi.Models.Movie;

/// <summary>
///     Моедль ответа от tmdb по деталям фильм
/// </summary>
public class DetailsResponseDto
{
    public bool? Adult { get; set; }
    public string? BackdropPath { get; set; }
    public BelongsToCollection? BelongsToCollection { get; set; }
    public int Budget { get; set; }
    public Genre[]? Genre { get; set; }
    public string? Homepage { get; set; }
    public int Id { get; set; }
    public string? ImdbId { get; set; }
    public string[]? OriginCountry { get; set; }
    public string? OriginalLanguage { get; set; }
    public string? OriginalTitle { get; set; }
    public string? Overview { get; set; }
    public double?  Popularity { get; set; }
    public string? PosterPath { get; set; }
    public ProductionCompany[]? ProductionCompanies { get; set; }
}