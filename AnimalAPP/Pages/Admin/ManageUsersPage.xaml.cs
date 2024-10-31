using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Newtonsoft.Json;
using System.Collections.Generic;
using AnimalAPP.Models;

namespace AnimalAPP.Pages.Admin
{
    public partial class ManageUsersPage : ContentPage
    {
        public ManageUsersPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Cargar lista de usuarios desde Preferences
            string usersJson = Preferences.Get("UsersList", "[]");
            List<User> usersList = JsonConvert.DeserializeObject<List<User>>(usersJson) ?? new List<User>();

            // Asignar lista de usuarios al CollectionView
            UsersCollectionView.ItemsSource = usersList;
        }
    }
}
