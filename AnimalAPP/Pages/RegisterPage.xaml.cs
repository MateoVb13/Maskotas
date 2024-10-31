// Views/RegisterPage.xaml.cs
using AnimalAPP.Services;
using AnimalAPP.Models;

namespace AnimalAPP.Pages
{
    public partial class RegisterPage : ContentPage
    {
        private readonly AuthService _authService;

        public RegisterPage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombre = NombreEntry.Text,
                Email = EmailEntry.Text,
                Password = PasswordEntry.Text,
                Rol = RolPicker.SelectedItem?.ToString()
            };

            if (await _authService.RegistrarUsuario(usuario))
            {
                await DisplayAlert("Éxito", "Usuario registrado correctamente", "OK");
                await Navigation.PopAsync(); // Volver a la pantalla de login
            }
            else
            {
                await DisplayAlert("Error", "El usuario ya existe o hubo un error", "OK");
            }
        }
    }
}
