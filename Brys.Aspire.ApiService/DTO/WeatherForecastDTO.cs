namespace Brys.Aspire.ApiService.DTO;

public record WeatherForecastDTO(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}