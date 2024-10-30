using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages
{
    public partial class PetRegistrationPage : ContentPage
    {
        public PetRegistrationPage()
        {
            InitializeComponent();
        }

        // Método de evento para guardar la información de la mascota
        private void OnSavePet(object sender, EventArgs e)
        {
            // Lógica para guardar la información de la mascota
            DisplayAlert("Éxito", "La información de la mascota ha sido guardada.", "OK");
        }
    }
}
