using System.Net.Http.Json;
using TmbdApi.Json;
using TmbdApi.Models;

namespace TmbdApi;

/// <summary>
///     Ошибка от Tmdb.
/// </summary>
public class TmdbClientException : HttpRequestException
{
    /// <summary>
    ///     Успех ли? - ну даже не знаю.
    /// </summary>
    public bool Success { get; set; }
    
    /// <summary>
    ///     Код от Tmdb.
    /// </summary>
    public int StatusCode { get; set; }
    
    /// <summary>
    ///     Сообщение об ошибке от Tmdb.
    /// </summary>
    public string StausMessage { get; set; }

    /// <summary>
    ///     Парсинг и возврат ответа.
    /// </summary>
    /// <returns> Исключение от Tmdb. </returns>
    public static async Task<TmdbClientException> FromHttpResponseMessageAsync(HttpResponseMessage response,
        CancellationToken cancellationToken = default)
    {
        var result = await response.Content.ReadFromJsonAsync<ExceptionDto>(TmdbJson.Options, cancellationToken);
        return new TmdbClientException()
            { Success = result.Success, StatusCode = result.StatusCode, StausMessage = result.StatusMessage };
    }
}