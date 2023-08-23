using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    [Table("Doctors")]
    public class Doctor:BaseModel
    {
        public string title { get; set; }
        public string gender { get; set; }
       
        public virtual ICollection<prescription> prescriptions { get; set; } = new List<prescription>();
    }
}
