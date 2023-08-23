using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    [Table("Receteİlaclari")]

    public class receteİlac:BaseModel
    {
        public int ilacId { get; set; }
        public int receteId { get; set; }
        public int useTypeId { get; set; }
        public int periyot { get; set; }
        public int doz { get; set; }
        public int adet { get; set; }
        public virtual ilac İlac { get; set; }
        public virtual recete Recete { get; set; }
        public virtual useType UseType { get; set; }
        

    }
}
