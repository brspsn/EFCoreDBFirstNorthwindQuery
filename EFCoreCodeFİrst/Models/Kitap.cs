using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFİrst.Models
{
    [Table("Kitaplar")]
    public class Kitap:BaseModel
    {
        public int SayfaSayisi { get; set; }
        public string Isbn { get; set; }
        public int kategoriId { get; set; }
        public kategori kategori { get; set; }
        public virtual ICollection<Yazar> Yazarlar { get; set; }=new List<Yazar>();
        public virtual ICollection<YayınEvi> YayınEvleri { get; set; } = new List<YayınEvi>();


    }
}
