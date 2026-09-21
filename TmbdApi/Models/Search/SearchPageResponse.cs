namespace TmbdApi.Models.Search;
/// <summary>
///     Дто ответа, при запросам к Search.
/// </summary>
public class SearchPageResponse<T>
{
    /// <summary>
    ///     Страница.
    /// </summary>
    public int Page { get; set; } = 1;
    
    /// <summary>
    ///     Результат запроса.
    /// </summary>
    public T[] Results { get; set; }
    
    /// <summary>
    ///     Количесво страниц.
    /// </summary>
    public int TotalPages { get; set; } = 1;
    
    /// <summary>
    ///     Количество результатов.
    /// </summary>
    public int TotalResults { get; set; } = 0;
}