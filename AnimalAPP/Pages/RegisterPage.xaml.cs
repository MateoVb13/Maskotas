using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Para Preferences
using System.Text.RegularExpressions; // Para la expresi�n regular

namespace AnimalAPP.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }

            if (!IsValidEmail(email))
            {
                await DisplayAlert("Error", "Por favor, ingrese un correo v�lido en el formato example@dominio.com", "OK");
                return;
            }

            if (password != confirmPassword)
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
                return;
            }

            // Guardar el usuario en Preferences
            SaveUser(name, email, password);
            await DisplayAlert("�xito", "Registro exitoso. Ahora puede iniciar sesi�n.", "OK");
            await Navigation.PopAsync(); // Volver a la p�gina de login
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void SaveUser(string name, string email, string password)
        {
            Preferences.Set("UserName", name);
            Preferences.Set("UserEmail", email);
            Preferences.Set("UserPassword", password);
        }
    }
}
