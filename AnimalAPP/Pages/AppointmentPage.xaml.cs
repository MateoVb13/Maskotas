using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages
{
    public partial class AppointmentPage : ContentPage
    {
        // Lista de servicios disponibles
        private readonly List<string> availableServices = new List<string>
        {
            "Consulta General",
            "Vacunación",
            "Desparasitación",
            "Peluquería",
            "Cirugía"
        };

        public AppointmentPage()
        {
            InitializeComponent();
            LoadPets();     // Cargar la lista de mascotas
            LoadServices(); // Cargar la lista de servicios
        }

        private void LoadPets()
        {
            // Cargar la lista de mascotas desde Preferences
            string petsJson = Preferences.Get("PetsList", "[]");
            List<Pet> petsList = JsonConvert.DeserializeObject<List<Pet>>(petsJson) ?? new List<Pet>();

            // Asignar la lista de mascotas como fuente de datos para el Picker
            PetPicker.ItemsSource = petsList;
        }

        private void LoadServices()
        {
            // Asignar la lista de servicios disponibles al Picker de servicios
            ServicePicker.ItemsSource = availableServices;
        }

        private async void OnConfirmAppointmentClicked(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una mascota
            if (PetPicker.SelectedItem is Pet selectedPet)
            {
                // Verificar si se seleccionó un servicio
                if (ServicePicker.SelectedItem is string selectedService)
                {
                    DateTime selectedDate = DatePicker.Date;
                    TimeSpan selectedTime = TimePicker.Time;
                    DateTime appointmentDateTime = selectedDate + selectedTime;

                    // Aquí puedes guardar la cita en una base de datos o en Preferences
                    await DisplayAlert("Cita Confirmada",
                        $"Mascota: {selectedPet.Name}\nServicio: {selectedService}\nFecha y Hora: {appointmentDateTime}", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "Por favor, selecciona un servicio para la cita.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, selecciona una mascota para agendar la cita.", "OK");
            }
        }
    }
}
