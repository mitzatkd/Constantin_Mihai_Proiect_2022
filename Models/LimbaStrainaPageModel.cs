using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Constantin_Mihai_Proiect.Data;

namespace Constantin_Mihai_Proiect.Models
{
    public class LimbaStrainaPageModel:PageModel
    {
        public List<AtribuireLimbaStraina> AtribuireLbStLista;
        public void PopuleazaAtribuireLimbaStraina(Constantin_Mihai_ProiectContext context,
        Angajat angajat)
        {
            var toateLimbile = context.LimbaStraina;
            var limbiStraine = new HashSet<int>(
            angajat.LimbiStraineVorbite.Select(c => c.AngajatID));
            AtribuireLbStLista = new List<AtribuireLimbaStraina>();
            foreach (var lb in toateLimbile)
            {
                AtribuireLbStLista.Add(new AtribuireLimbaStraina
                {
                    LimbaStrainaID = lb.ID,
                    Denumire = lb.Denumirea,
                    Atribuita = limbiStraine.Contains(lb.ID)
                });
            }
        }
        public void UpdateLimbiStraine(Constantin_Mihai_ProiectContext context,
        string[] limbiSelectate, Angajat adaugareLb)
        {
            if (limbiSelectate == null)
            {
                adaugareLb.LimbiStraineVorbite = new List<LimbaStrainaVorbita>();
                return;
            }
            var limbiSelectateHS = new HashSet<string>(limbiSelectate);
            var limbiStraine = new HashSet<int>
            (adaugareLb.LimbiStraineVorbite.Select(c => c.LimbaStraina.ID));
            foreach (var lb in context.LimbaStraina)
            {
                if (limbiSelectateHS.Contains(lb.ID.ToString()))
                {
                    if (!limbiStraine.Contains(lb.ID))
                    {
                        adaugareLb.LimbiStraineVorbite.Add(
                        new LimbaStrainaVorbita
                        {
                            AngajatID = adaugareLb.ID,
                            LimbaStrainaID = lb.ID
                        });
                    }
                }
                else
                {
                    if (limbiStraine.Contains(lb.ID))
                    {
                        LimbaStrainaVorbita courseToRemove
                        = adaugareLb
                        .LimbiStraineVorbite
                        .SingleOrDefault(i => i.LimbaStrainaID == lb.ID);
                        context.Remove(courseToRemove);
                    }
                }
            }
        }
    }
}
