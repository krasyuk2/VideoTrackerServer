namespace TmbdApi;

/// <summary>
///     Настройки подключения.
/// </summary>
public class TmdbOption
{
    /// <summary>
    ///     Адрес Api.
    /// </summary>
    public string BaseUrl { get; set; } = "https://api.themoviedb.org/3/";
    
    /// <summary>
    ///     JWT токен авторизации.
    /// </summary>
    public string BearerToken { get; set; } = string.Empty;

    /// <summary>
    ///     Язык ответов.
    /// </summary>
    public string Language { get; set; } = "ru-RU";
}