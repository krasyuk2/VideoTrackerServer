namespace TmbdApi.Models.Search;

public class MultiResponseDto
{
    public int? Page  { get; set; }
    public ResultsMultiDto[] results { get; set; }
}