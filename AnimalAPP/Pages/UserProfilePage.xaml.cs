using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Para Preferences

namespace AnimalAPP.Pages
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Recupera los datos del usuario desde Preferences
            string name = Preferences.Get("UserName", "Nombre no disponible");
            string email = Preferences.Get("UserEmail", "Correo no disponible");

            // Asigna los valores a los Labels en la interfaz
            NameLabel.Text = name;
            EmailLabel.Text = email;
        }
    }
}
