using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public Guid guid { get; set; }= Guid.NewGuid();
        public string? AD { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; } = true;
        public DateTime olusturmaTarihi { get; private set; }=DateTime.Now;
        public DateTime guncellemeTarihi { get; set; }=DateTime.Now;


    }
}
