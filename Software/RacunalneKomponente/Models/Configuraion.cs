using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacunalneKomponente.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPredefined { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Component> Components { get; set; }
    }
}
