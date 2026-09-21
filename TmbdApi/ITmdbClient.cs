namespace TmbdApi;

/// <summary>
///     Интерфейс доступа к TMBD.
/// </summary>
public interface ITmdbClient
{
    Task<> GetMultiAsync(string query, int page = 1, CancellationToken cancellationToken = default);
}