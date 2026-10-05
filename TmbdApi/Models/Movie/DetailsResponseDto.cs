namespace TmbdApi.Models.Movie;

/// <summary>
///     Модель ответа от tmdb по деталям фильм
/// </summary>
public class DetailsResponseDto
{
    /// <summary>
    ///     Взрослый ли контент.
    /// </summary>
    public bool? Adult { get; set; }
    
    /// <summary>
    ///     Путь до фона.
    /// </summary>
    public string? BackdropPath { get; set; }
    
    /// <summary>
    ///     В какую коллекцию входит.
    /// </summary>
    public BelongsToCollection? BelongsToCollection { get; set; }
    
    /// <summary>
    ///     Бюджет.
    /// </summary>
    public int Budget { get; set; }
    
    /// <summary>
    ///     Жанры.
    /// </summary>
    public Genre[]? Genre { get; set; }
    
    /// <summary>
    ///     Домашняя страница.
    /// </summary>
    public string? Homepage { get; set; }
    
    /// <summary>
    ///     Идентификатор.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Идентификатор в imdb.
    /// </summary>
    public string? ImdbId { get; set; }
    
    /// <summary>
    ///     Страны производства.
    /// </summary>
    public string[]? OriginCountry { get; set; }
    
    /// <summary>
    ///     Оригинальный язык.
    /// </summary>
    public string? OriginalLanguage { get; set; }
    
    /// <summary>
    ///     Оригинальное название.
    /// </summary>
    public string? OriginalTitle { get; set; }
    
    /// <summary>
    ///     Описание.
    /// </summary>
    public string? Overview { get; set; }
    
    /// <summary>
    ///     Популярность.
    /// </summary>
    public double?  Popularity { get; set; }
    
    /// <summary>
    ///     Путь до постера.
    /// </summary>
    public string? PosterPath { get; set; }
    
    /// <summary>
    ///     Перечень компаний, которые работали над фильмом.
    /// </summary>
    public ProductionCompany[]? ProductionCompanies { get; set; }
}