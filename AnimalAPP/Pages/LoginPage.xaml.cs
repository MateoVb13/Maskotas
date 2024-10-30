using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Para Preferences

namespace AnimalAPP.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (ValidateUser(email, password))
            {

                await Navigation.PushAsync(new Detalle()); // Redirigir a la página principal
            }
            else
            {
                await DisplayAlert("Error", "Correo o contraseña incorrectos", "OK");
            }
        }

        private bool ValidateUser(string email, string password)
        {
            // Obtener los valores guardados en Preferences
            string savedEmail = Preferences.Get("UserEmail", null);
            string savedPassword = Preferences.Get("UserPassword", null);

            // Validar si coinciden los datos ingresados con los datos guardados
            return email == savedEmail && password == savedPassword;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Navegar a la página de registro
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
