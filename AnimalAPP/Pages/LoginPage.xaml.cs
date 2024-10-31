// Views/LoginPage.xaml.cs
using AnimalAPP.Services;
using AnimalAPP.Models;
using AnimalAPP.Pages;

namespace AnimalAPP.Pages
{
    public partial class LoginPage : ContentPage
    {
        private readonly AuthService _authService;

        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var email = EmailEntry.Text;
            var password = PasswordEntry.Text;

            var usuario = await _authService.Login(email, password);
            if (usuario != null)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");

                var citaService = App.ServiceProvider.GetService<CitaService>();

                if (_authService.EsAdmin(usuario))
                {
                    await Navigation.PushAsync(new CitaPage(citaService)); // Navegar a CitaPage con CitaService inyectado
                }
                else
                {
                    await Navigation.PushAsync(new CitaPage(citaService)); // Navegar a CitaPage con CitaService inyectado
                }
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage(_authService));
        }
    }
}
