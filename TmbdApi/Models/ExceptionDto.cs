namespace TmbdApi.Models;

/// <summary>
///     Ответ ошибки от TMDB.
/// </summary>
public class ExceptionDto
{
    /// <summary>
    ///     Успех ли - ? - што.
    /// </summary>
    public bool Success { get; set; }
    
    /// <summary>
    ///     Код ошибки от TMDB.
    /// </summary>
    public int StatusCode { get; set; }
    
    /// <summary>
    ///     Сообщение об ошибке от TMDB.
    /// </summary>
    public string StatusMessage { get; set; }
}