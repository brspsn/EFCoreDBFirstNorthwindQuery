using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteNew.models
{
    [Table("Receteler")]

    public class recete:BaseModel
    {
        public int doctorId { get; set; }
        public string? receteTuru { get; set; }
        public string? EreceteNo { get; set; }
        public string? description { get; set; }
        public virtual doktor Doktor { get; set; }
        public virtual ICollection<receteİlac> Receteİlaclari { get; set; } = new List<receteİlac>();
        public virtual ICollection<Tani> Tanilar { get; set; } = new List<Tani>();

    }
}
