using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages
{
    public partial class PetRegistrationPage : ContentPage
    {
        public PetRegistrationPage()
        {
            InitializeComponent();
        }

        // M�todo de evento para guardar la informaci�n de la mascota
        private void OnSavePet(object sender, EventArgs e)
        {
            // L�gica para guardar la informaci�n de la mascota
            DisplayAlert("�xito", "La informaci�n de la mascota ha sido guardada.", "OK");
        }
    }
}
