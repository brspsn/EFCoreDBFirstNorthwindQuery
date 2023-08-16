using efCoreLinqSorgulari.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Identity.Client;
using System.Diagnostics.Metrics;

namespace efCoreLinqSorgulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            ////1- soru
            ////SELECT CategoryName,Description FROM Categories ORDER BY CategoryName

            //var result = context.Categories.Select(c => new
            //{
            //    c.CategoryName,
            //    c.Description
            //}).OrderBy(c => c.CategoryName).ToList(); 
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            ////3.soru
            ////SELECT firstName,LastName,HireDate FROM Employees ORDER BY Hiredate DESC
            //var result=context.Employees.Select(e=> new Employee 
            //{ 
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    HireDate = e.HireDate,
            //}).OrderByDescending(e=>e.HireDate);

            ////5. soru
            ////SELECT Fax,CompanyName,Phone,HomePage,Country FROM Suppliers ORDER BY Country DESC, CompanyName ASC

            //var result = context.Suppliers.Select(s => new Supplier
            //{
            //    Fax = s.Fax,
            //    CompanyName = s.CompanyName,
            //    Phone = s.Phone,
            //    HomePage = s.HomePage,
            //    Country = s.Country
            //}).OrderByDescending(s => s.Country).ThenBy(s=>s.CompanyName);

            ////6.soru
            ////SELECT companyName,ContactName FROM Customers WHERE City='buenos aires'

            //var result=context.Customers.Where(c => c.City == "Buenos aires").Select(c=> new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    //City = c.City, where varsa sorguyu selectin önüne alımak daha hızlı ve mantıklı olur
            //    //yada içinde de city sorgusunu da yapmamız gerekiyor.
            //    ContactName = c.ContactName,
            //}).ToList();


            ////7.soru

            //var resutl = context.Products.Where(p => p.UnitsInStock == 0).Select(p => new Product
            //{
            //    ProductName = p.ProductName,
            //    UnitPrice = p.UnitPrice,
            //    QuantityPerUnit = p.QuantityPerUnit,
            //});



            ////8.soru

            //var result = context.Orders.Where(o => o.OrderDate == DateTime.Parse("1997-05-19")).Select(o => new Order
            //{
            //    OrderDate = o.OrderDate,
            //    Freight= o.Freight,
            //    ShippedDate = o.ShippedDate,
            //    CustomerId = o.CustomerId,
            //});

            ////9.soru
            //var result = context.Employees.Where(e => !e.Country.Contains("USA")).Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    e.Country
            //});

            ////10.soru
            //var result = context.Orders.Where(o => o.ShippedDate > o.RequiredDate).Select(o => new
            //{
            //    o.EmployeeId,
            //    o.OrderId,
            //    o.CustomerId,
            //    o.RequiredDate,
            //    o.ShippedDate,
            //});

            ////11.Soru
            ////SELECT * FROM Customers WHERE City Like 'A%' OR City like 'B%' 

            //var result = context.Customers.Where(c => c.City.StartsWith("A") || c.City.StartsWith("B"));


            ////12.soru
            //var result = context.Orders.Where(o => o.Freight >= 500).Select(o => new
            //{
            //    o.OrderId,
            //    o.CustomerId,
            //    o.Freight
            //});

            ////13.soru
            //var result = context.Products.Where(p => p.UnitsOnOrder != 0).Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitsInStock,
            //    p.UnitsOnOrder,
            //    p.ReorderLevel
            //});
            ////there are have a problem ask your manager!!!!!!!!!!!!!!!!!!!!!!

            ////14.soru

            //var result = context.Customers.Where(c => c.Fax != null).Select(c => new
            //{
            //    c.CompanyName,
            //    c.ContactName,
            //    c.Fax
            //});
            ////14.soru
            //var result = context.Customers.Where(c => c.Fax != null).Select(c => new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    Fax = c.Fax,
            //    ContactName = c.ContactName,
            //});

            ////15.soru
            //var result = context.Employees.Where(e => e.ReportsTo == null).Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName
            //});

            //16.soru
            //var result = context.Customers.Where(c => c.Fax != null).Select(c => new
            //{
            //    c.CompanyName,
            //    c.ContactName,
            //    c.Fax
            //}).OrderBy(c=>c.CompanyName).ToList();

            //17.soru
            //var result = context.Customers.Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).Select(c => new
            //{
            //    c.CompanyName,
            //    c.ContactName,
            //}).OrderByDescending(c=>c.ContactName).ToList();



            ////18.soru

            //var result = context.Employees.Where(e => e.BirthDate.Value.Year >= 1950 && e.BirthDate.Value.Year < 1960).Select(e => new Employee
            //{
            //    FirstName = e.FirstName,
            //    LastName = e.LastName,
            //    BirthDate = e.BirthDate,
            //});

            //19.soru

            //there are have little problem ask your manager please!!!!!!!!!!!!!!!!!!!!!!!!

            ////20.soru
            //var result = context.Orders.Where(o => o.ShipPostalCode.StartsWith("02389")).Select(o => new
            //{
            //    o.OrderId,
            //    o.ShipPostalCode,
            //    o.OrderDate
            //});

            ////21.soru

            //var result = context.Customers.Where(c => !c.ContactTitle.Contains("Sales")).Select(c => new Customer
            //{
            //    ContactName = c.ContactName,
            //    ContactTitle = c.ContactTitle
            //});

            ////22.soru
            //var result = context.Employees.Where(e => !e.City.Contains("seattle")).Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    e.City,
            //    e.Country
            //});

            ////23.soru

            //var result = context.Customers.Where(c => (c.Country == "Mexico" || c.Country == "Spain") && c.City != "Madrid");


            ////24.soru

            //var result = context.Employees.Select(e => new
            //{
            //    contactInfo = e.FirstName + " " + e.LastName + "can be reached at x" + e.Extension + "."
            //});

            //25-------------------------------

            //26.soru

            //var result = context.Employees.Select(e => new
            //{

            //    HireAgeAccurate=(e.HireDate-e.BirthDate)/365.0,
            //    HireAgeInnaccurate = e.HireDate.Value.Year - e.BirthDate.Value.Year


            //});

            //foreach (var e in result)
            //{
            //    Console.WriteLine(e.HireAgeAccurate + "           " + e.HireAgeInnaccurate);
            //}

            //27.soru
            //var result = context.Employees.Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    datename = e.BirthDate.Value.ToString("MMMM")
            //}); ;

            //30.soru 31----32
            //var result = context.Products.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category.CategoryName

            //}).Where(p => p.CategoryName=="seafood");

            //33.soru
            //var result = context.Orders.Where(o => o.ShippedDate > o.RequiredDate).Take(37).Select(o => new
            //{
            //    o.OrderId,
            //    o.Employee.FirstName,
            //    o.Employee.LastName
            //}).OrderBy(o=>o.LastName).ThenBy(o=>o.FirstName);

            //34.soru

            //var result = context.Products.Select(p => new
            //{
            //    ProductName = p.ProductName,
            //    totalUnits = p.OrderDetails.Sum(od => od.Quantity)


            //}).Where(a => a.totalUnits < 200);
            // navitational proporty düzgun olmasaydı

            //var result = context.Products.GroupJoin(context.OrderDetails, p => p.ProductId, od => od.ProductId, (Product, OrderDetails) => new
            //{
            //    ProductName = Product.ProductName,
            //    totalUnits = OrderDetails.Sum(od => od.Quantity)
            //}).Where(a => a.totalUnits < 200);
            ////34.sorunun sonuuuu

            // 35 soru
            //var result = context.Orders.Select(o => new
            //{
            //    o.Customer.CustomerId,
            //    o.Customer.CompanyName,
            //    o.OrderDate,
            //    o.CustomerId.Count()

            //}).Where(o => o.OrderDate >= DateTime.Parse("1996-12-31"));


            //36. soru
            var result = context.Orders.Select(o => new
            {
                companyName = o.Customer.CompanyName,
                totalprice = o.OrderDetails.Sum(od => (od.Quantity * od.UnitPrice)),
                o.OrderId
            }).Where(o => o.totalprice > 10000).GroupBy(o => o.companyName);
         




            /////yeni kayıt oluşturucağımız zaman yeni bir kategori oluşturulup değişiklikleri kaydet diyoruz
            //Category category = new Category();
            //Console.WriteLine("kategori adı giriniz");
            //category.CategoryName = Console.ReadLine();
            //Console.WriteLine("kategori açıklmasını giriniz");
            //category.Description = Console.ReadLine();

            //context.Categories.Add(category);
            //context.SaveChanges();



            ///// hazırda bulunan bir kategori içerisindeki kategorinin nameini değiştirmek için ise
            //Category category = context.Categories.Where(c => c.CategoryId == 2).First();
            //Category category = context.Categories.Find(2);
            //Category category = context.Categories.FirstOrDefault(c => c.CategoryId == 2);
            //category.CategoryName = "Condiments";
            //context.Categories.Update(category);


        }

        //public static DateTime CalculateAge(DateTime HireDate, DateTime BirthDate)
        //{
        //    DateTime Age = HireDate - BirthDate;
        //    return Age;
        //}


    }
}