namespace API_AnimalApp.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Mascota { get; set; }
        public string Dueño { get; set; }
        public string Motivo { get; set; }
    }
}
