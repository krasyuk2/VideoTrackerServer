namespace TmbdApi.Models.Movie;

/// <summary>
///     В какую коллекцию входит. 
/// </summary>
public class BelongsToCollection
{
    /// <summary>
    ///     Идентификатор коллекции.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Название.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Путь до постера.
    /// </summary>
    public string? PosterPath { get; set; }
    
    /// <summary>
    ///     Путь до фона.
    /// </summary>
    public string? BackdropPath { get; set; }
}