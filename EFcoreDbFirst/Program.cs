using EFcoreDbFirst.Models;

namespace EFcoreDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            var result = context.Products.Select(p => new
            {
                ürünAdi = p.ProductName,
                kategoriAdi = p.Category.CategoryName,
                tedarikçi = p.Supplier.CompanyName
            });
            foreach (var item in result)
            {
                Console.WriteLine(item.ürünAdi + " ," + item.kategoriAdi + ", " + item.tedarikçi);
            }

            var result1 = context.Categories.Select(c => new
            {
                c.CategoryName,
                ürünadedi = c.Products.Count,

            }); 
            foreach (var c in result1)
            {
                Console.WriteLine(c.CategoryName + " " +c.ürünadedi);
            }
        }

    }
}