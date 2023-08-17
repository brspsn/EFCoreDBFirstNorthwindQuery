using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFİrst.Models
{
    public class BaseModel
    {
        [Key]
        public int ID { get; set; }
        public Guid Guid { get; set; }= Guid.NewGuid();
        public string Ad { get; set; }
        public bool SilindiMi { get; set; }= false;
        public bool Aktifmi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; private set; }= DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; }=DateTime.Now;


    }
}
