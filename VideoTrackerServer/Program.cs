using VideoTrackerServer.Application.Implementations;
using VideoTrackerServer.Application.Options;
using VideoTrackerServer.Domain.Abstractions;
using VideoTrackerServer.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<VideoInformationMapper>();
builder.Services.AddScoped<IVideoService, VideoService>();

builder.Services.AddOptions<ContentTypeDetectionOption>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();