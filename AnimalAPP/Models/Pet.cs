using System.Collections.Generic;

namespace AnimalAPP.Models
{
    public class Pet
    {
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public List<string> History { get; set; } = new List<string>();
    }
}
