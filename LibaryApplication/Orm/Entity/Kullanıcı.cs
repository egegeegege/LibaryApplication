using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryApplication.Orm.Entity
{
    public class Kullanıcı : BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TelefonNo { get; set; }
        [Required]
        public string Sifre { get; set; }
    }
}
