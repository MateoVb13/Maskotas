using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAPP.Models
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
