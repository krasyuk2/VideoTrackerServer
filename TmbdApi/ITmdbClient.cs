using TmbdApi.Models.Search;

namespace TmbdApi;

/// <summary>
///     Интерфейс доступа к TMBD.
/// </summary>
public interface ITmdbClient
{
    Task<MultiResponseDto?> GetMultiAsync(string query, int page = 1, CancellationToken cancellationToken = default);
}