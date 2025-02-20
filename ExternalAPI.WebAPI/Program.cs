
using ExternalAPI.WebAPI;

public class Program
{
    public static void main(string[] args)
    {

        var app = Startup.WebApplicationBuilder();

        Startup.AppSetup(app);

        app.Run();
    }

    internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}