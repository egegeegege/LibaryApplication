using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryApplication.Orm.Entity
{
    public abstract class BaseEntity 
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; }
        public bool Aktifmi { get; set; }
    }
}
