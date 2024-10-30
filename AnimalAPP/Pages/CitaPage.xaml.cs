using System;
using System.Collections.ObjectModel;
using AnimalAPP.Models;
using AnimalAPP.Services;

using System.Collections.ObjectModel;

namespace AnimalAPP.Pages;

public partial class CitaPage : ContentPage
{
    private ObservableCollection<Cita> citas = new ObservableCollection<Cita>();
    private AuthService authService = new AuthService();

    public CitaPage()
    {
        InitializeComponent();
        CitasListView.ItemsSource = citas;
    }

    //private void OnCrearCitaClicked(object sender, EventArgs e)
    //{
    //    var cita = new Cita
    //    {
    //        FechaHora = FechaPicker.Date + HoraPicker.Time,
    //        Mascota = MascotaEntry.Text,
    //        Dueño = authService.LoginUser?.Nombre, // Propiedad en AuthService para usuario activo
    //        Motivo = MotivoEntry.Text
    //    };

    //    citas.Add(cita);
    //}
}