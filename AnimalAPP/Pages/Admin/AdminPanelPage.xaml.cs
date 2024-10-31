using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages.Admin
{
    public partial class AdminPanelPage : ContentPage
    {
        public AdminPanelPage()
        {
            InitializeComponent(); // Aseg�rate de que esta l�nea est� en el constructor.
        }

        private async void OnManageUsersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageUsersPage()); // Navega a la p�gina de gesti�n de usuarios
        }

        private async void OnManagePetsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManagePetsPage()); // Navega a la p�gina de gesti�n de mascotas
        }

        private async void OnManageAppointmentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageAppointmentsPage()); // Navega a la p�gina de gesti�n de citas
        }
    }
}
