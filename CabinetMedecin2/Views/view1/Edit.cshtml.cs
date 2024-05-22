using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CabinetMedecin.Data;
using CabinetMedecin2.Models;

namespace CabinetMedecin2.Views.view1
{
    public class EditModel : PageModel
    {
        private readonly CabinetMedecin.Data.GestionDbContext _context;

        public EditModel(CabinetMedecin.Data.GestionDbContext context)
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

            var assistante =  await _context.Assistante.FirstOrDefaultAsync(m => m.AssistantId == id);
            if (assistante == null)
            {
                return NotFound();
            }
            Assistante = assistante;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Assistante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssistanteExists(Assistante.AssistantId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AssistanteExists(int id)
        {
            return _context.Assistante.Any(e => e.AssistantId == id);
        }
    }
}
