using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace TmbdApi;

/// <summary>
///     Класс расширение.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Добавление TMDB клиента.
    /// </summary>
    public static IHttpClientBuilder AddTmdbClient(
        this IServiceCollection services, Action<TmdbOption> configure)
    {
        services.AddOptions<TmdbOption>()
            .Configure(configure);

        return services.AddHttpClient<ITmdbClient, TmdbClient>((provider, client) =>
        {
            var option = provider.GetRequiredService<IOptions<TmdbOption>>().Value;
            client.BaseAddress = new Uri(option.BaseUrl);
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", option.BearerToken);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        });
    }
    
    /// <summary>
    ///     Добавление TMDB-клиента из секции конфигурации.
    /// </summary>
    public static IHttpClientBuilder AddTmdbClient(
        this IServiceCollection services, IConfiguration section)
        => services.AddTmdbClient(section.Bind);
}