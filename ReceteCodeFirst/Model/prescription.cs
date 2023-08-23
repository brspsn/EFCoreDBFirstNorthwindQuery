using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    [Table("prescriptions")]
    public class prescription: BaseModel
    {
        public string prescriptionNum { get; set; }
        public string nationalİd { get; set; }
        
        public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();
        public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
        public virtual ICollection<prescriptionMedicine> PrescriptionMedicines { get; set; }= new List<prescriptionMedicine>();
        public virtual Doctor Doctor { get; set; }

    }
}
