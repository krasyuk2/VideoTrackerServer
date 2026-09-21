using System.Text.Json;
using System.Text.Json.Serialization;

namespace TmbdApi.Json;

/// <summary>
///     Настройки парсинга Json для дат.
/// </summary>
public class TmdbDateOnlyConverter : JsonConverter<DateOnly?>
{
    /// <summary>
    ///     Формат парсинга.
    /// </summary>
    private readonly string Format = "yyyy-MM-dd";
    
    /// <inheritdoc/>
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;
        var value = reader.GetString();
        if (string.IsNullOrWhiteSpace(value))
            return null;
        return DateOnly.TryParseExact(value, Format, out var date) ? date : null;
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        if(value == null)
            writer.WriteNullValue();
        else writer.WriteStringValue(value.Value.ToString(Format));
    }
}