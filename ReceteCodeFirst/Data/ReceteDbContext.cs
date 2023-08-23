using Microsoft.EntityFrameworkCore;
using ReceteCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Data
{
    public class ReceteDbContext : DbContext
    {
        public ReceteDbContext()
        {

        }

        public ReceteDbContext(DbContextOptions<ReceteDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Recete;Integrated Security=True;TrustServerCertificate=Yes");

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<prescription> prescription { get; set; }
        public virtual DbSet<prescriptionMedicine> prescriptionMedicines { get; set; }

    }
}
