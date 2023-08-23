using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    [Table("Doktorlar")]
    public class doktor:BaseModel
    {
        [MaxLength(11)]
        public string Tckn { get; set; }
        public string pinCode { get; set; }
    }
}
