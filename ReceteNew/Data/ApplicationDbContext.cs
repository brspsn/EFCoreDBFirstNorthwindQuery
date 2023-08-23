using Microsoft.EntityFrameworkCore;
using ReceteNew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public virtual DbSet<doktor> doktorlar { get; set;}
        public virtual DbSet<ilac> ilaclar { get; set; }
        public virtual DbSet<recete> receteler { get; set; }
        public virtual DbSet<receteİlac> receteilaclari { get; set; }
        public virtual DbSet<Tani> tanilar { get; set; }
        public virtual DbSet<useType> kullanımSekilleri { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ReceteNew;Integrated Security=True;TrustServerCertificate=Yes");
    }
}
