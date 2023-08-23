using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    [Table("Medicines")]
    public class Medicine:BaseModel
    {
        public string barcode { get; set; }
        public virtual ICollection<prescription> prescriptions { get; set; } = new List<prescription>();

    }
}
