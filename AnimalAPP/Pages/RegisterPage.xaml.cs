using AnimalAPP.Models;
using AnimalAPP.Services;

namespace AnimalAPP.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly AuthService authService;

    public RegisterPage(AuthService authService)
    {
        InitializeComponent();
        this.authService = authService;
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        var nombre = NombreEntry.Text;
        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;
        var rol = RolPicker.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rol))
        {
            await DisplayAlert("Error", "Por favor complete todos los campos.", "OK");
            return;
        }

        var usuario = new Usuario
        {
            Nombre = nombre,
            Email = email,
            Password = password,
            Rol = rol
        };

        if (authService.RegistrarUsuario(usuario))
        {
            await DisplayAlert("Éxito", "Usuario registrado correctamente", "OK");
            await Navigation.PopAsync(); // Volver a la pantalla de login
        }
        else
        {
            await DisplayAlert("Error", "El usuario ya existe", "OK");
        }
    }
}