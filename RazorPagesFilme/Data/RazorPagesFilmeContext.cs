using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilme.Models;

namespace RazorPagesFilme.Data
{
    public class RazorPagesFilmeContext : DbContext
    {
        public RazorPagesFilmeContext (DbContextOptions<RazorPagesFilmeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilme.Models.Filme> Filme { get; set; } = default!;
    }
}
