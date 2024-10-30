using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages
{
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        // Método de evento para confirmar una cita
        private void OnConfirmAppointment(object sender, EventArgs e)
        {
            // Lógica para confirmar la cita
            DisplayAlert("Cita Confirmada", "Su cita ha sido agendada correctamente.", "OK");
        }
    }
}
