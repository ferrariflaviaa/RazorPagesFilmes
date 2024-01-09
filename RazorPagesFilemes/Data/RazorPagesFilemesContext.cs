using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilemes.Modelo;

namespace RazorPagesFilemes.Data
{
    public class RazorPagesFilemesContext : DbContext
    {
        public RazorPagesFilemesContext (DbContextOptions<RazorPagesFilemesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilemes.Modelo.Filme> Filme { get; set; } = default!;
    }
}
