using TmbdApi.Models.Search;

namespace TmbdApi;

/// <summary>
///     Интерфейс доступа к TMBD.
/// </summary>
public interface ITmdbClient
{
    /// <summary>
    ///     Запрос на выполнение мультипоиска - найти разом: Сериалы, фильмы, людей.
    ///     https://api.themoviedb.org/3/search/multi
    /// </summary>
    /// <param name="query"> Запрос по которому будем искать.</param>
    /// <param name="page"> Страница. </param>
    /// <param name="adult"> Добавить ли взрослый контент. </param>
    /// <param name="cancellationToken"> Токен отмены. </param>
    /// <returns> Результаты поиска по запросу. </returns>
    Task<SearchPageResponse<MultiResponseDto>?> GetMultiAsync(string query, int page = 1, bool adult = false, CancellationToken cancellationToken = default);
}