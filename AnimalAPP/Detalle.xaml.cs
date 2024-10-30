using Microsoft.Maui.Controls;

namespace AnimalAPP

{
    public partial class Detalle : ContentPage
{
    public Detalle()
    {
        InitializeComponent();
    }

    private async void OnMenuButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Maestro());
    }
}
}