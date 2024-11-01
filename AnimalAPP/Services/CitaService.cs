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
            var response = await _httpClient.GetAsync("citas");
            if (!response.IsSuccessStatusCode)
                return null;

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Configuración personalizada para deserialización
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true, // Ignora mayúsculas y minúsculas en nombres de propiedades
            };

            return JsonSerializer.Deserialize<List<Cita>>(jsonResponse, opciones);
        }

        public async Task<bool> CrearCitaAsync(Cita cita)
        {
            var json = JsonSerializer.Serialize(cita);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("citas", content);
            return response.IsSuccessStatusCode;
        }
    }
}
