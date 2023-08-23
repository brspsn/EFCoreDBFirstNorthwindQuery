using ReceteNew.Controllers;
using ReceteNew.Data;
using ReceteNew.models;

namespace ReceteNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 17-18-08 ders
            #region

            //List<ilac> ilaclar = new List<ilac>();
            //ilac ilac = new ilac();
            //ilaclar.Add(new ilac { AD = "Xanax", barcode = "0923750972" });
            //ilaclar.Add(new ilac { AD = "Xanax", barcode = "0923750972" });
            //ilaclar.Add(new ilac { AD = "ahmedi", barcode = "9823659823650" });
            //ilaclar.Add(new ilac { AD = "talcid", barcode = "8632540823*957" });

            //ApplicationDbContext context = new ApplicationDbContext();
            //context.ilaclar.AddRange(ilaclar);//liste halinde eklemiş olucaz
            //context.SaveChanges();

            ////Category category = context.Categories.Find(2);
            ////Category category = context.Categories.FirstOrDefault(c => c.CategoryId == 2);
            ////category.CategoryName = "Condiments";
            //ilac Dbilac =context.ilaclar.Find(5);
            //Dbilac.AD="Mahmudo";
            //context.ilaclar.Update(Dbilac);
            //context.SaveChanges();

            //ApplicationDbContext context = new ApplicationDbContext();
            //List<Tani> tanilar = new List<Tani>();

            //while (true)
            //{
            //    Tani tani = new Tani();
            //    Console.WriteLine("Tanı İsmi giriniz");
            //    tani.AD=Console.ReadLine();
            //    Console.WriteLine("Tanı kodu giriniz");
            //    tani.code = Console.ReadLine();
            //    tanilar.Add(tani);
            //    Console.WriteLine("Yeni kayıt eklemek iste misiniz?E/H");
            //    string input=Console.ReadLine();
            //    if (input.ToUpper()=="H")
            //    {
            //        break;
            //    }
            //}
            //context.tanilar.AddRange(tanilar);
            //context.SaveChanges();
            #endregion

            //Console.WriteLine("Tani Adı giriniz");
            //Tani tani = new Tani();
            //tani.AD = Console.ReadLine();
            //Console.WriteLine("Tani kodu giriniz");
            //tani.code = Console.ReadLine();

            //if (TaniController.Ekle(tani))
            //    Console.WriteLine("işlem başarılı");
            //else
            //    Console.WriteLine("hata oluştu...");

            //int id = TaniController.Ekle(tani);
            //Console.WriteLine($"eklemiş olduğunuz tani {id} ile database e eklenmiştir.");

            //List<Tani> taniListesi = new List<Tani>();
            //taniListesi.Add(new Tani { AD = "test1", code = "832694" });
            //taniListesi.Add(new Tani { AD = "test2", code = "92186491" });
            //taniListesi.Add(new Tani { AD = "test3", code = "0836553" });
            //taniListesi.Add(new Tani { AD = "test4", code = "83265o8236" });

            //taniListesi = TaniController.CokluEkle(taniListesi);

            //Console.WriteLine("aramak istediğiniz tanının harflarini tuşlayınız");
            //List<Tani> aramaSonucu = TaniController.CallByName(Console.ReadLine());
            //if (aramaSonucu.Count != 0)
            //{
            //    Console.WriteLine("bulunan tanı sayısı: " + aramaSonucu.Count);
            //    foreach (Tani item in aramaSonucu)
            //    {
            //        Console.WriteLine(item.AD);
            //    }
            //}
            //else { Console.WriteLine("herhangi bir sonuç bulunamadı"); }
            #endregion

            doktor doktor = new doktor();
            recete recete = new recete();
            List<receteİlac> receteilaclari = new List<receteİlac>();
            recete.Doktor = doktor;
            recete.Receteİlaclari = receteilaclari;
            Console.WriteLine("lütfen adınızı giriniz");
            doktor.AD=Console.ReadLine();
            Console.WriteLine("lütfen TCKN numrasını giriniz");
            doktor.Tckn = Console.ReadLine();
            Console.WriteLine("pin giriniz");
            doktor.pinCode = Console.ReadLine();
            receteilaclari.Add(new receteİlac
            {
                receteId = 11,
                ilacId = 1212,
                adet=2,
            });

            recete.Tanilar.Add(new Tani
            {
                AD = "deneme",
                code = "121313"
            });

            ReceteController.Created(recete);
            //if ()
            // Console.WriteLine("başarılı");
            //else 
            //    Console.WriteLine("404 not found"); 

            

            ///burada recete eklemeye başlamadan önce, sırasıyla doktor tanı ve ilacları eklememiz gerekiyor. bu kontroller yapıldıktan sonra receteyi oluşturmuş olacağız mantığıyla
            ///ilerledim. ancak enson receteyi sisteme nasıl eklemem gerekiyor. burada takıldım














        }
    }
}