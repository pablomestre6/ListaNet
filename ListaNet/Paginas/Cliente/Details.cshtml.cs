using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ListaNet.Data;
using ListaNet.Models;

namespace ListaNet.Paginas.Cliente
{
    public class DetailsModel : PageModel
    {
        private readonly ListaNet.Data.ListaNetContext _context;

        public DetailsModel(ListaNet.Data.ListaNetContext context)
        {
            _context = context;
        }

      public Produto Produto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Servico)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            else 
            {
                Produto = produto;
            }
            return Page();
        }
    }
}
