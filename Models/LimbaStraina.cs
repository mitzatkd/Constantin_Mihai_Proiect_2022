using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constantin_Mihai_Proiect.Models
{
    public class LimbaStraina
    {
        public int ID { get; set; }
        public string Denumirea { get; set; }
        public ICollection<LimbaStrainaVorbita> LimbiStraineVorbite { get; set; }
    }
}
