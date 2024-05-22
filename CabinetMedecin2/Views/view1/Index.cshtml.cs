using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CabinetMedecin.Data;
using CabinetMedecin2.Models;

namespace CabinetMedecin2.Views.view1
{
    public class IndexModel : PageModel
    {
        private readonly CabinetMedecin.Data.GestionDbContext _context;

        public IndexModel(CabinetMedecin.Data.GestionDbContext context)
        {
            _context = context;
        }

        public IList<Assistante> Assistante { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Assistante = await _context.Assistante.ToListAsync();
        }
    }
}
