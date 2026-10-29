using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacunalneKomponente.Models
{
    public class User : Person
    {
        public string Email { get; set; }
        public List<Configuration> Configurations { get; set; }
    }
}
