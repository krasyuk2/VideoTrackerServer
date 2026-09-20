using Microsoft.Extensions.Options;

namespace TmbdApi;

/// <summary>
///     Реализация доступа к TMBD.
/// </summary>
public class TmdbClient : ITmdbClient
{
    /// <summary>
    ///     Http client
    /// </summary>
    private readonly HttpClient _httpClient;
    
    /// <summary>
    ///     Настройки подключения.
    /// </summary>
    private readonly TmdbOption _option;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public TmdbClient(HttpClient httpClient, IOptions<TmdbOption> option)
    {
        _httpClient = httpClient;
        _option = option.Value;
    }
}