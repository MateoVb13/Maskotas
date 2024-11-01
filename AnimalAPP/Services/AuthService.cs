// AuthService.cs
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AnimalAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalAPP.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> RegistrarUsuario(Usuario usuario)
        {
            var json = JsonSerializer.Serialize(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://localhost:5194/api/usuarios/register", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<Usuario> LoginAsync(string email, string password)
        {
            var loginData = new { Email = email, Password = password };
            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Llama al endpoint de login de la API
            var response = await _httpClient.PostAsync("usuarios/login", content);

            if (!response.IsSuccessStatusCode)
            {
                return null; // Credenciales incorrectas o error en la API
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Usuario>(jsonResponse);
        }

        public bool EsAdmin(Usuario usuario)
        {
            return usuario?.Rol == "Admin";
        }
    }   
}
