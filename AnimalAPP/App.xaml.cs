using AnimalAPP.Pages;
using AnimalAPP.Services;
using AnimalAPP.Pages;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;

namespace AnimalAPP
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            // Obtener AuthService del contenedor de servicios y pasar a LoginPage
            var authService = serviceProvider.GetService<AuthService>();
            MainPage = new NavigationPage(new LoginPage(authService));
        }
    }
}

