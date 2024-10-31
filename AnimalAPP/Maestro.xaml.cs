using AnimalAPP.Pages;
using Microsoft.Maui.Controls;
using AnimalAPP.Pages.Admin;


namespace AnimalAPP
{
    public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();
    }

        private async void OnUserProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserProfilePage());
    }

    private async void OnPetRegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PetRegistrationPage());
    }

    private async void OnAppointmentClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppointmentPage());
    }

    private async void OnServiceClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicePage());
    }

    private async void OnAdminPanelClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdminPanelPage());
    }

        // Método de evento para cerrar sesión
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Lógica para cerrar sesión (redireccionar a la pantalla de inicio de sesión, por ejemplo)
            bool confirmLogout = await DisplayAlert("Cerrar Sesión", "¿Está seguro de que desea cerrar sesión?", "Sí", "No");
            if (confirmLogout)
            {
                // Redirige a la página de inicio o de inicio de sesión
                await Navigation.PopToRootAsync();
            }
        }
    }
}