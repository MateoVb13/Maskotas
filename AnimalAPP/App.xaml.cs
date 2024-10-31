using AnimalAPP.Pages;
using AnimalAPP.Services;
using AnimalAPP.Pages;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;

namespace AnimalAPP
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = serviceProvider;

            // Configurar la página principal de la aplicación
            MainPage = new NavigationPage(new LoginPage(ServiceProvider.GetService<AuthService>()));
        }
    }
}

