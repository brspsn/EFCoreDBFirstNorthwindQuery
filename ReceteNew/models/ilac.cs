using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    [Table("ilaclar")]

    public class ilac:BaseModel
    {
        public string barcode { get; set; }
        public virtual ICollection<receteİlac> Receteİlaclari { get; set; }=new List<receteİlac>();


    }
}
