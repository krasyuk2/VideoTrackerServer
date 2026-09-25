using TmbdApi;
using VideoTrackerServer.Application.Implementations;
using VideoTrackerServer.Application.Implementations.MediaHandler;
using VideoTrackerServer.Application.Options;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<VideoInformationMapper>();
builder.Services.AddScoped<IVideoService, VideoService>();
builder.Services.AddScoped<IMediaContentResolverService, MediaContentResolverService>();
builder.Services.AddScoped<IMediaProviderService, MediaProviderService>();

builder.Services.AddScoped<MediaResolver>();
builder.Services.AddScoped<IMediaHandler, MovieHandler>();
builder.Services.AddScoped<IMediaHandler, AnimeHandler>();
builder.Services.AddScoped<IMediaHandler, SerialHandler>();
builder.Services.AddScoped<IMediaHandler, UnrecognizedHandler>();
builder.Services.AddScoped<IMediaHandler, VideoHandler>();

builder.Services.AddOptions<ContentTypeDetectionOption>()
    .Bind(builder.Configuration.GetSection(nameof(ContentTypeDetectionOption)));

builder.Services.AddTmdbClient(client =>
{
    client.BaseUrl = "https://api.themoviedb.org/3/";
    client.BearerToken = "Ошибся но где";
    client.Language = "ru-RU";
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();