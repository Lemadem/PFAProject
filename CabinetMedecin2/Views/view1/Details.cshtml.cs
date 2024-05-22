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
    public class DetailsModel : PageModel
    {
        private readonly CabinetMedecin.Data.GestionDbContext _context;

        public DetailsModel(CabinetMedecin.Data.GestionDbContext context)
        {
            _context = context;
        }

        public Assistante Assistante { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assistante = await _context.Assistante.FirstOrDefaultAsync(m => m.AssistantId == id);
            if (assistante == null)
            {
                return NotFound();
            }
            else
            {
                Assistante = assistante;
            }
            return Page();
        }
    }
}
