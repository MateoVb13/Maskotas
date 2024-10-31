using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages.Admin
{
    public partial class ManagePetsPage : ContentPage
    {
        public ManagePetsPage()
        {
            InitializeComponent();
            LoadPets();
        }

        private void LoadPets()
        {
            // Cargar lista de mascotas desde Preferences
            string petsJson = Preferences.Get("PetsList", "[]");
            List<Pet> petsList = JsonConvert.DeserializeObject<List<Pet>>(petsJson) ?? new List<Pet>();

            // Asignar lista de mascotas al CollectionView
            PetsCollectionView.ItemsSource = petsList;
        }
    }
}
