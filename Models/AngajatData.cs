using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constantin_Mihai_Proiect.Models
{
    public class AngajatData
    {
        public IEnumerable<Angajat> Angajati { get; set; }
        public IEnumerable<LimbaStraina> LimbiStraine { get; set; }
        public IEnumerable<LimbaStrainaVorbita> LimbiStraineVorbite { get; set; }
    }
}
