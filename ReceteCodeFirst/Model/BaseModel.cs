using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Model
{
    public class BaseModel
    {
        public int id { get; set; }
        public Guid guid { get; set; }= Guid.NewGuid();
        public string name { get; set; }
        public string Description { get; set; }
        public bool isDeleted { get; set; }= false;
        public bool isActive { get; set; }= true;
        public DateTime createTime { get; private  set; }= DateTime.Now;
        public DateTime updateTime { get; set; } = DateTime.Now;
    }
}
