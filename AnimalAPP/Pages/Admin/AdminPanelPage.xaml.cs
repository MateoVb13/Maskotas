using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages.Admin
{
    public partial class AdminPanelPage : ContentPage
    {
        public AdminPanelPage()
        {
            InitializeComponent(); // Asegúrate de que esta línea esté en el constructor.
        }

        private async void OnManageUsersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageUsersPage()); // Navega a la página de gestión de usuarios
        }

        private async void OnManagePetsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManagePetsPage()); // Navega a la página de gestión de mascotas
        }

        private async void OnManageAppointmentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManageAppointmentsPage()); // Navega a la página de gestión de citas
        }
    }
}
