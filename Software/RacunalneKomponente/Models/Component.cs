using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacunalneKomponente.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public ComponentType Type { get; set; }
        public string Specifications { get; set; }
        public decimal Price { get; set; }
    }
}
