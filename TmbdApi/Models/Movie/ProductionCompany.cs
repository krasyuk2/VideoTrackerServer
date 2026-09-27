namespace TmbdApi.Models.Movie;

/// <summary>
///     Дто компаний который работали над медиа.
/// </summary>
public class ProductionCompany
{
    /// <summary>
    ///     Идентификатор компании.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    ///     Путь до лого компании.
    /// </summary>
    public string? LogoPath { get; set; }
    
    /// <summary>
    ///     Название.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    ///     Страна.
    /// </summary>
    public string? OriginCountry { get; set; }
}