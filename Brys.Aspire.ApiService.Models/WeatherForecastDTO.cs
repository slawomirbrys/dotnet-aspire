﻿namespace Brys.Aspire.ApiService.Models;

public record WeatherForecastDto(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}