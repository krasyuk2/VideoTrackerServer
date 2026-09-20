using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using TmbdApi.Models.Search;

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
    
    public async Task<MultiResponseDto?> GetMultiAsync(string query, int page = 1, CancellationToken cancellationToken = default)
    {
        var path =
            $"https://api.themoviedb.org/3/search/multi?query={query}&include_adult=false&language={_option.Language}&page=1";
        return await GetAsync<MultiResponseDto>(path, cancellationToken);
    }

    /// <summary>
    ///     Метод отправки запроса на api TMDB.
    /// </summary>
    /// <param name="path"> Путь запроса. </param>
    /// <param name="ct"> Токен отмены. </param>
    private async Task<T?> GetAsync<T>(string path, CancellationToken ct)
    {
        using var response = await _httpClient.GetAsync(path, ct);
        if (response.StatusCode == HttpStatusCode.NotFound)
            return default;
        if (!response.IsSuccessStatusCode)
            throw new Exception("Test"); // TODO: TMDB отдает ответ об ошибки нужно спарсить

        return await response.Content.ReadFromJsonAsync<T>(cancellationToken: ct);
    }
}