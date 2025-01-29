using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myspace.Contexts
{
    internal class testDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-77H1T1P\\SQLEXPRESS;Database=Test;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
