using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using VideoTrackerServer.Application.Options;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис, который предоставляет информацию медиа.
/// </summary>
public class MediaProviderService : IMediaProviderService
{
    /// <summary>
    ///     Конфиги поиска по типу.
    /// </summary>
    private readonly ContentTypeDetectionOption _typeDetectionOption;

    /// <summary>
    ///     Перечисление символов, обрезаем при первом вхождении.
    /// </summary>
    private readonly char[] Trail = "(—[|;.?!".ToCharArray();

    /// <summary>
    ///     Обработка.
    /// </summary>
    private readonly Regex Terminator = new(
        @"\d[\d\s,]*(?=(?:сезон|сери|эпизод))" +
        @"|\bсезон\w*|\bсери[йяию]\b|\bэпизод\w*" +
        @"|\bсмотр\w*|\bонлайн\b|\bбесплатн\w*|\bкачеств\w*",
        RegexOptions.IgnoreCase);
    
    /// <summary>
    ///     Регулярное выражение, которое удаляет в начале строки.
    /// </summary>
    private readonly Regex DeleteWordsStart =
        new Regex(@"^(сериал|фильм|мультфильм|аниме|смотреть)[\s:—–-]", RegexOptions.IgnoreCase);

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaProviderService(IOptions<ContentTypeDetectionOption> typeDetectionOption)
    {
        _typeDetectionOption = typeDetectionOption.Value;
    }
    
    /// <inheritdoc/>
    public string GetMediaName(VideoInformation videoInformation)
    {
        var title = videoInformation.OgProperty.Title;
        if (!string.IsNullOrEmpty(title))
            return TrimTitle(title);
        return TrimTitle(videoInformation.Title);
    }
    
    /// <inheritdoc/>
    public ContentVideoTypes GetMediaType(VideoInformation videoInformation)
    {
        return GetContentTypeMedia(videoInformation);
    }
    
    /// <summary>
    ///     Обработать заголовок (для получения имени)
    /// </summary>
    /// <param name="title"> Заголовок. </param>
    /// <returns> В надежде - название. </returns>
    private string TrimTitle(string title)
    {
        title = DeleteWordsStart.Replace(title!, string.Empty);
        var cut = title.IndexOfAny(Trail);
        if(cut >= 0) title = title[..cut];
        var terminate = Terminator.Match(title);
        if (terminate.Success) title = title[..terminate.Index];
        return title.Trim(Trail).Trim();
    }
    
       /// <summary>
    ///     Получить тип медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Тип медиа. </returns>
    private ContentVideoTypes GetContentTypeMedia(VideoInformation videoInformation)
    {
        var score = new Dictionary<ContentVideoTypes, double>();
        foreach (var (type, text) in EnumerateMediaSources(videoInformation))
        {
            if(!_typeDetectionOption.SourceWeights.TryGetValue(type, out var weight))
                continue;
            if(string.IsNullOrEmpty(text)) continue;
            foreach (var rule in _typeDetectionOption.Rules)
            {
                if (rule.IsRegex)
                {
                    var regex = new Regex(rule.KeyWord, RegexOptions.IgnoreCase);
                    var match = regex.Matches(text);
                    if (match.Count > 0)
                        score.TryAdd(rule.Type, weight);
                }
                if(text.Contains(rule.KeyWord))
                    score.TryAdd(rule.Type, weight);
            }
        }
        var sum = score.Sum(x => x.Value);
        if(sum <= 0)
            return ContentVideoTypes.Unrecognized;
        
        var best = score.MaxBy(x => x.Value);
        return best.Value >= _typeDetectionOption.Threshold ? best.Key : ContentVideoTypes.Unrecognized;
    }

    private IEnumerable<(MediaSourceTypes Type, string? Text)> EnumerateMediaSources(VideoInformation videoInformation)
    {
        yield return (MediaSourceTypes.Title, videoInformation.Title);
        yield return (MediaSourceTypes.OgUrl, videoInformation.OgProperty.Url);
        yield return (MediaSourceTypes.OgTitle, videoInformation.OgProperty.Title);
        yield return (MediaSourceTypes.OgDescription, videoInformation.OgProperty.Description);
        yield return (MediaSourceTypes.OgUrl, videoInformation.OgProperty.Url);
        yield return (MediaSourceTypes.PageUrl, videoInformation.WebSiteUrl);
        yield return (MediaSourceTypes.PlayerUrl, videoInformation.PlayerUrl);
    }
}