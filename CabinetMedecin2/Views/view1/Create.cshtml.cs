using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CabinetMedecin.Data;
using CabinetMedecin2.Models;

namespace CabinetMedecin2.Views.view1
{
    public class CreateModel : PageModel
    {
        private readonly CabinetMedecin.Data.GestionDbContext _context;

        public CreateModel(CabinetMedecin.Data.GestionDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Assistante Assistante { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assistante.Add(Assistante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
