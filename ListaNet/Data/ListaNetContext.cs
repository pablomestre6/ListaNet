using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListaNet.Models;

namespace ListaNet.Data
{
    public class ListaNetContext : DbContext
    {
        internal readonly object Produtos;

        public ListaNetContext (DbContextOptions<ListaNetContext> options)
            : base(options)
        {
        }

        public DbSet<ListaNet.Models.Produto>? Produto { get; set; }
    }
}
