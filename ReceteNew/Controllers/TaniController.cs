using ReceteNew.Data;
using ReceteNew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.Controllers
{
    public static class TaniController
    {
        public static int Ekle(Tani tani)
        {

            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.tanilar.Add(tani);
                context.SaveChanges();

                //Tani inpuTani = context.tanilar.Find(tani);
                return tani.Id;

            }
            catch (Exception Ex)
            {
                //Console.WriteLine("Database Bağlantı Hatası");
                return 0;
            }
            
            
        }
        public static List<Tani> CokluEkle(List<Tani> taniListesi)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.tanilar.AddRange(taniListesi);
                context.SaveChanges();
                return taniListesi;
            }
            catch (Exception)
            {
                return new List<Tani>();
            }
        }
        public static bool sil(Tani tani)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                tani.isDeleted = true;
                context.tanilar.Update(tani);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool hardDeleted(Tani tani)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.tanilar.Remove(tani);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static Tani GetByName(string TaniAdi)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                return context.tanilar.FirstOrDefault(t => t.AD == TaniAdi);
            }
            catch (Exception)
            {
                return new Tani();
            }
        }
        public static List<Tani> CallByName(string CallName)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                return context.tanilar.Where(t => t.AD.Contains(CallName)).ToList<Tani>();

            }
            catch (Exception)
            {
                return new List<Tani>();
            }
        }


    }
}
