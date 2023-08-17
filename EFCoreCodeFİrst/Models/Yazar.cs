using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFİrst.Models
{
    [Table("Yazarlar")]//DAtaAnotation-deniliyor
    public class Yazar:BaseModel
    {
        public string Ozgecmis { get; set; }
        public virtual ICollection<Kitap> Kitaplar { get; set; }=new List<Kitap>();
        public virtual ICollection<YayınEvi> YayınEvleri { get; set; } = new List<YayınEvi>();

    }
} 

