using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages
{
    public partial class PetRegistrationPage : ContentPage
    {
        public PetRegistrationPage()
        {
            InitializeComponent(); // Asegúrate de que esta línea esté en el constructor
        }

        private async void OnSavePetClicked(object sender, EventArgs e)
        {
            string petName = PetNameEntry.Text;
            string species = SpeciesEntry.Text;
            string breed = BreedEntry.Text;

            if (string.IsNullOrEmpty(petName) || string.IsNullOrEmpty(species) || string.IsNullOrEmpty(breed))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }

            // Crear el objeto Pet
            Pet newPet = new Pet
            {
                Name = petName,
                Species = species,
                Breed = breed,
                History = new List<string> { "Primera visita: revisión general" }
            };

            // Cargar la lista de mascotas desde Preferences
            var petsList = LoadPets();
            petsList.Add(newPet);

            // Guardar la lista actualizada de mascotas en Preferences
            SavePets(petsList);

            await DisplayAlert("Éxito", "Mascota registrada correctamente.", "OK");
            await Navigation.PopAsync();
        }

        private List<Pet> LoadPets()
        {
            string petsJson = Preferences.Get("PetsList", "[]");
            return JsonConvert.DeserializeObject<List<Pet>>(petsJson) ?? new List<Pet>();
        }

        private void SavePets(List<Pet> pets)
        {
            string petsJson = JsonConvert.SerializeObject(pets);
            Preferences.Set("PetsList", petsJson);
        }
    }
}
