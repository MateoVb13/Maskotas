using AnimalAPP.Services;
using AnimalAPP.Pages;

namespace AnimalAPP.Pages
{
    public partial class LoginPage : ContentPage
    {
        private readonly AuthService authService;

        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            this.authService = authService;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var email = EmailEntry.Text;
            var password = PasswordEntry.Text;

            var usuario = authService.Login(email, password);
            if (usuario != null)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
                if (authService.EsAdmin(usuario))
                    await Navigation.PushAsync(new CitaPage()); // Página de administración
                else
                    await Navigation.PushAsync(new CitaPage()); // Página estándar para usuarios
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage(authService));
        }
    }
}
