using eSaleSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSaleSolution.Data.EF
{
    public class eSaleDBContext : DbContext
    {
        public eSaleDBContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<UDTItem> UDTItems { get; set; }

    }
}
