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

            // Llama a AuthService para verificar las credenciales
            var usuario = await _authService.LoginAsync(email, password);
            if (usuario != null)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");

                // Obtén el servicio CitaService desde el contenedor de dependencias
                var citaService = App.ServiceProvider.GetService<CitaService>();

                if (_authService.EsAdmin(usuario))
                {
                    await Navigation.PushAsync(new CitaPage(citaService)); // Página de administrador
                }
                else
                {
                    // Pasa la instancia de CitaService al navegar a CitaPage
                    await Navigation.PushAsync(new CitaPage(citaService)); // Página de citas
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
