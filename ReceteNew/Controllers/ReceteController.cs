using Microsoft.EntityFrameworkCore.Diagnostics;
using ReceteNew.Data;
using ReceteNew.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.Controllers
{
    public static class ReceteController
    {
        public static recete Created(recete recete)
        {
			try
			{
                ApplicationDbContext context = new ApplicationDbContext();
                context.receteler.Add(recete);
                context.SaveChanges();
                return recete;
            }
			catch
			{
                Console.WriteLine("başarısız");
                return new recete();
            }
        }
    }
}
