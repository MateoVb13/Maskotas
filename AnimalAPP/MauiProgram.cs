// MauiProgram.cs
using Microsoft.Maui.Hosting;
using AnimalAPP.Services;

namespace AnimalAPP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Configurar HttpClient y servicios
            builder.Services.AddHttpClient<AuthService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7037/api/");
            });

            builder.Services.AddHttpClient<CitaService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7037/api/");
            });

            return builder.Build();
        }
    }
}
