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
    public class IndexModel : PageModel
    {
        private readonly ListaNet.Data.ListaNetContext _context;

        public IndexModel(ListaNet.Data.ListaNetContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produto != null)
            {
                Produto = await _context.Produto.ToListAsync();
            }
        }
    }
}
