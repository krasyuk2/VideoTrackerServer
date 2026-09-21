namespace TmbdApi.Models.Search;

/// <summary>
///     Дто ответа мультипоиска.
/// </summary>
public class MultiResponseDto
{
    /// <summary>
    ///     Взрослый ли контент.
    /// </summary>
    public bool? Adult { get; set; }
    
    /// <summary>
    ///     Фон.
    /// </summary>
    public string? BackdropPath { get; set; }
    
    /// <summary>
    ///     Идентификатор медиа.
    /// </summary>
    public int Id  { get; set; }
    
    /// <summary>
    ///     Название на указанном языке. (фильм)
    /// </summary>
    public string? Title { get; set; }
    
    /// <summary>
    ///     Название на оригинальном языке. (фильм)
    /// </summary>
    public string? OriginalTitle { get; set; }
    
    /// <summary>
    ///     Название на указанном языке. (сериал)
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Название на оригинальном языке. (сериал)
    /// </summary>
    public string? OriginalName { get; set; }
    
    /// <summary>
    ///      Описание.
    /// </summary>
    public string? Overview { get; set; }
    
    /// <summary>
    ///     Постер.
    /// </summary>
    public string? PosterPath { get; set; }
    
    /// <summary>
    ///     Тип медиа.
    /// </summary>
    public string? MediaType { get; set; }
    
    /// <summary>
    ///     Оригинальный язык.
    /// </summary>
    public string? OriginalLanguage { get; set; }
    
    /// <summary>
    ///     Идентификаторы жанров.
    /// </summary>
    public int[]? GenreIds { get; set; }
    
    /// <summary>
    ///     Популярность 
    /// </summary>
    public double? Popularity { get; set; }
    
    /// <summary>
    ///     Дата выхода первой серии.
    /// </summary>
    public string? FirstAirDate { get; set; }
    
    /// <summary>
    ///     Дата выхода фильма.
    /// </summary>
    public string? ReleaseDate { get; set; }
    
    /// <summary>
    ///     Грань между фильмом и эротикой.
    /// </summary>
    public bool? Softcore { get; set; }
    
    /// <summary>
    ///     Является ли произведение - дополнительным материалом. (трейлер, сцены удаленные и т.д.).
    /// </summary>
    public bool? Video { get; set; }
    
    /// <summary>
    ///     Оценка.
    /// </summary>
    public double? VoteAverage { get; set; }
    
    /// <summary>
    ///     Сколько голосовало.
    /// </summary>
    public int? VoteCount { get; set; }
    
    /// <summary>
    ///     Страны производства.
    /// </summary>
    public string[]? OriginCountry { get; set; }
}