using Microsoft.Maui.Controls;

namespace AnimalAPP
{
    public partial class Detalle : ContentPage
    {
        public Detalle()
        {
            InitializeComponent();
        }

        // Método para abrir el menú lateral
        private async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            // Navega a la página Maestro
            await Navigation.PushAsync(new Maestro());
        }
    }
}
