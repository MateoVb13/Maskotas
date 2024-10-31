using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            LoadUserData();
            LoadPets();
        }

        private void LoadUserData()
        {
            // Recupera los datos del usuario desde Preferences
            string name = Preferences.Get("UserName", "Nombre no disponible") ?? "Nombre no disponible";
            string email = Preferences.Get("UserEmail", "Correo no disponible") ?? "Correo no disponible";

            NameLabel.Text = name;
            EmailLabel.Text = email;
        }

        private void LoadPets()
        {
            // Cargar la lista de mascotas desde Preferences y asegurar que no sea nulo
            string petsJson = Preferences.Get("PetsList", "[]");
            List<Pet> petsList = JsonConvert.DeserializeObject<List<Pet>>(petsJson) ?? new List<Pet>();

            // Asignar la lista de mascotas a la vista
            PetsCollectionView.ItemsSource = petsList;
        }
    }
}
