using System.Collections.Immutable;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using VideoTrackerServer.Application.Options;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Domain.Models;

namespace VideoTrackerServer.Application.Implementations;

/// <summary>
///     Сервис определения типа контента, и получение его информации
/// </summary>
public class MediaContentResolverService : IMediaContentResolverServer
{
    /// <summary>
    ///     Конфиги по определению типа.
    /// </summary>
    private readonly ContentTypeDetectionOption _option;

    /// <summary>
    ///     Конструктор.
    /// </summary>
    public MediaContentResolverService(IOptions<ContentTypeDetectionOption> option)
    {
        _option = option.Value;
    }
    
    /// <summary>
    ///     Получить название видео.
    /// </summary>
    /// <returns> Название видео без мусора. </returns>
    private string GetNameMedia(VideoInformation videoInformation)
    {
        
    }

    /// <summary>
    ///     Получить тип медиа.
    /// </summary>
    /// <param name="videoInformation"> Информация о медиа. </param>
    /// <returns> Тип медиа. </returns>
    private ContentVideoTypes GetContentMediaType(VideoInformation videoInformation)
    {
        var score = new Dictionary<ContentVideoTypes, double>(); 
        SetScore(score, videoInformation.Title.ToLower());
        if (CheckMaxScore(score)) return score.MaxBy(x => x.Value).Key;
        
        SetScore(score, videoInformation.OgProperty.Title?.ToLower());
        if (CheckMaxScore(score)) return score.MaxBy(x => x.Value).Key;
        
        SetScore(score, videoInformation.OgProperty.Description?.ToLower());
        if (CheckMaxScore(score)) return score.MaxBy(x => x.Value).Key;
        
        SetScore(score, videoInformation.OgProperty.Url?.ToLower());
        return score.Values.Sum() <= 0 ? ContentVideoTypes.Unrecognized : score.MaxBy(x => x.Value).Key;
    }

    private void SetScore(Dictionary<ContentVideoTypes, double> score, string? source)
    {
        if(string.IsNullOrEmpty(source)) return;
        foreach (var rule in _option.Rules)
        {
            if (rule.IsRegex)
            {
                var regex = new  Regex(rule.KeyWord);
                var match = regex.Matches(source);
                if(match.Count <= 0) continue;
            }
            else
            {
                if (!source.Contains(rule.KeyWord)) continue;
            }
            if(!score.TryAdd(rule.Type, rule.Weight))
                score[rule.Type] += rule.Weight;
        }
    }

    /// <summary>
    ///     Проверить что мы уже уверены какой тип.
    /// </summary>
    /// <param name="score"> Словарь тип - вероятность. </param>
    /// <returns> Есть ли значение которое 100% верное. </returns>
    private bool CheckMaxScore(Dictionary<ContentVideoTypes, double> score) => score.Values.Max() >= 1.0d;
}

