using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCRUD.Models
{
    internal class NewsContext: DbContext
    {
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-77H1T1P\\SQLEXPRESS;Database=News;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
