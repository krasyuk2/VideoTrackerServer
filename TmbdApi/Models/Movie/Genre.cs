namespace TmbdApi.Models.Movie;

/// <summary>
///     Дто жанра.
/// </summary>
public class Genre
{
    /// <summary>
    ///     Идентификатор жанра.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Наименование жанра.
    /// </summary>
    public string?  Name { get; set; }
}