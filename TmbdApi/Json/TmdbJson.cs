using System.Text.Json;

namespace TmbdApi.Json;

/// <summary>
///     Настройки Json для ответов tmdb.
/// </summary>
public static class TmdbJson
{
    /// <summary>
    ///     Получить настройки для snake_case.
    /// </summary>
    public static JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
    };
}