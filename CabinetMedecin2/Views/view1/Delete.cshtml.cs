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
    public class DeleteModel : PageModel
    {
        private readonly CabinetMedecin.Data.GestionDbContext _context;

        public DeleteModel(CabinetMedecin.Data.GestionDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assistante = await _context.Assistante.FindAsync(id);
            if (assistante != null)
            {
                Assistante = assistante;
                _context.Assistante.Remove(Assistante);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
