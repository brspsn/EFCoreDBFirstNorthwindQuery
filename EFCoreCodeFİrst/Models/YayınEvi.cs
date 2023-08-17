using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFİrst.Models
{
    [Table("YayınEvleri")]
    public class YayınEvi:BaseModel
    {
        public string Adres { get; set; }

        public virtual ICollection<Yazar> Yazarlar { get; set; } = new List<Yazar>();
        public virtual ICollection<Kitap> Kitaplar { get; set; } = new List<Kitap>();


    }
}
