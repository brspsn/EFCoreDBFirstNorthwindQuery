using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    [Table("Tanilar")]

    public class Tani:BaseModel
    {
        public string code { get; set; }
        public virtual ICollection<recete> Receteler { get; set; }= new List<recete>();

    }
}
