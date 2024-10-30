using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages
{
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        // M�todo de evento para confirmar una cita
        private void OnConfirmAppointment(object sender, EventArgs e)
        {
            // L�gica para confirmar la cita
            DisplayAlert("Cita Confirmada", "Su cita ha sido agendada correctamente.", "OK");
        }
    }
}
