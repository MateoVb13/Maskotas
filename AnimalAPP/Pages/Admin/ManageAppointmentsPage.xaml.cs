using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages.Admin
{
    public partial class ManageAppointmentsPage : ContentPage
    {
        public ManageAppointmentsPage()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            // Cargar la lista de citas desde Preferences
            string appointmentsJson = Preferences.Get("AppointmentsList", "[]");
            List<Appointment> appointmentsList = JsonConvert.DeserializeObject<List<Appointment>>(appointmentsJson) ?? new List<Appointment>();

            // Asignar la lista de citas al CollectionView
            AppointmentsCollectionView.ItemsSource = appointmentsList;
        }
    }
}
