using Microsoft.Maui.Controls;

namespace AnimalAPP
{
    public partial class Detalle : ContentPage
    {
        public Detalle()
        {
            InitializeComponent();
        }

        // M�todo para abrir el men� lateral
        private async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            // Navega a la p�gina Maestro
            await Navigation.PushAsync(new Maestro());
        }
    }
}
