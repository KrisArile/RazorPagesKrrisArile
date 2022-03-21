#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesArileKris.Models;

namespace RazorPagesKrrisArile.Data
{
    public class RazorPagesKrrisArileContext : DbContext
    {
        public RazorPagesKrrisArileContext (DbContextOptions<RazorPagesKrrisArileContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesArileKris.Models.Sheet> Sheet { get; set; }
    }
}
