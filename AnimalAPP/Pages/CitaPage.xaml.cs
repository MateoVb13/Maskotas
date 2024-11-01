// Views/CitaPage.xaml.cs
using System.Collections.ObjectModel;
using AnimalAPP.Models;
using AnimalAPP.Services;
using Microsoft.Maui.Controls;

namespace AnimalAPP.Pages
{
    public partial class CitaPage : ContentPage
    {
        private readonly CitaService _citaService;
        public ObservableCollection<Cita> Citas { get; set; } = new ObservableCollection<Cita>();


        public CitaPage(CitaService citaService)
        {
            InitializeComponent();
            _citaService = citaService;
            BindingContext = this;
            CargarCitas(); // Llama a este método para cargar las citas al iniciar la página
        }

        private async void CargarCitas()
        {
            var citas = await _citaService.ObtenerCitasAsync();
            if (citas != null)
            {
                Citas.Clear();
                foreach (var cita in citas)
                {
                    Console.WriteLine($"Cita: {cita.Mascota}, FechaHora: {cita.FechaHora}");
                    Citas.Add(cita);
                }
            }
        }

        private async void OnCrearCitaClicked(object sender, EventArgs e)
        {
            var nuevaCita = new Cita
            {
                FechaHora = FechaPicker.Date + HoraPicker.Time,
                Mascota = MascotaEntry.Text,
                Dueño = DueñoEntry.Text,
                Motivo = MotivoEntry.Text
            };

            if (await _citaService.CrearCitaAsync(nuevaCita))
            {
                await DisplayAlert("Éxito", "Cita creada correctamente", "OK");
                CargarCitas();
            }
            else
            {
                await DisplayAlert("Error", "No se pudo crear la cita", "OK");
            }
        }
    }
}
