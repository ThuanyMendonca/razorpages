using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilme.Data;
using RazorPagesFilme.Models;

namespace RazorPagesFilme.Pages.Filmes
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesFilme.Data.RazorPagesFilmeContext _context;

        public DeleteModel(RazorPagesFilme.Data.RazorPagesFilmeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Filme Filme { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FirstOrDefaultAsync(m => m.ID == id);

            if (filme == null)
            {
                return NotFound();
            }
            else 
            {
                Filme = filme;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }
            var filme = await _context.Filme.FindAsync(id);

            if (filme != null)
            {
                Filme = filme;
                _context.Filme.Remove(Filme);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
