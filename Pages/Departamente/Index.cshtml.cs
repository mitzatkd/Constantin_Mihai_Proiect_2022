using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_Proiect.Data;
using Constantin_Mihai_Proiect.Models;

namespace Constantin_Mihai_Proiect.Pages.Departamente
{
    public class IndexModel : PageModel
    {
        private readonly Constantin_Mihai_Proiect.Data.Constantin_Mihai_ProiectContext _context;

        public IndexModel(Constantin_Mihai_Proiect.Data.Constantin_Mihai_ProiectContext context)
        {
            _context = context;
        }

        public IList<Departament> Departament { get;set; }

        public async Task OnGetAsync()
        {
            Departament = await _context.Departament.ToListAsync();
        }
    }
}
