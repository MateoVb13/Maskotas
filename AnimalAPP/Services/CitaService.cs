using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AnimalAPP.Models;

namespace AnimalAPP.Services
{
    public class CitaService
    {
        private readonly HttpClient _httpClient;

        public CitaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cita>> ObtenerCitasAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7037/api/citas");
            if (!response.IsSuccessStatusCode)
                return null;

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Cita>>(jsonResponse);
        }

        public async Task<bool> CrearCitaAsync(Cita cita)
        {
            var json = JsonSerializer.Serialize(cita);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://tu-api.com/api/citas", content);
            return response.IsSuccessStatusCode;
        }
    }
}
