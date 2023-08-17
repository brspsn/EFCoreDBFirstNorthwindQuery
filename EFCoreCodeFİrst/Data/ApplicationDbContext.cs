using EFCoreCodeFİrst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFİrst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=KutuphaneCF;Integrated Security=True;TrustServerCertificate=Yes");


        public virtual DbSet<Yazar> Yazarlar { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<YayınEvi> YayınEvleri { get; set; }
        public virtual DbSet<kategori> Kategoriler { get; set; }


    }
}
