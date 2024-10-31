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

        // M�todo de evento para cerrar sesi�n
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // L�gica para cerrar sesi�n (redireccionar a la pantalla de inicio de sesi�n, por ejemplo)
            bool confirmLogout = await DisplayAlert("Cerrar Sesi�n", "�Est� seguro de que desea cerrar sesi�n?", "S�", "No");
            if (confirmLogout)
            {
                // Redirige a la p�gina de inicio o de inicio de sesi�n
                await Navigation.PopToRootAsync();
            }
        }
    }
}