using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    [Table("prescriptionMedicines")]
    public class prescriptionMedicine:BaseModel
    {
        public int prescriptionİd { get; set; }
        public int period { get; set; }
        public int dose { get; set; }
        public int piece { get; set; }
        public string useType { get; set; }

        public virtual prescription Prescription { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
    }
}
