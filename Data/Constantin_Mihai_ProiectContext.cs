using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_Proiect.Models;

namespace Constantin_Mihai_Proiect.Data
{
    public class Constantin_Mihai_ProiectContext : DbContext
    {
        public Constantin_Mihai_ProiectContext (DbContextOptions<Constantin_Mihai_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Constantin_Mihai_Proiect.Models.Angajat> Angajat { get; set; }

        public DbSet<Constantin_Mihai_Proiect.Models.Departament> Departament { get; set; }

        public DbSet<Constantin_Mihai_Proiect.Models.LimbaStraina> LimbaStraina { get; set; }

        public DbSet<Constantin_Mihai_Proiect.Models.Job> Job { get; set; }
    }
}
