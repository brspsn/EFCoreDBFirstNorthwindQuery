using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    [Table("Diagnoses")]
    public class Diagnosis:BaseModel
    {
        public string code { get; set; }
        public virtual ICollection<prescription> Prescriptions { get; set; } = new List<prescription>();
        public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
    }
}
