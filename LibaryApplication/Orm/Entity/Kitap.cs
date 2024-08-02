using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibaryApplication.Orm.Entity
{
    public class Kitap : BaseEntity
    {
        [Required]
        public string KitapAdı { get; set; }
        [Required]
        public int BaskıSayısı { get; set; }
        [Required]
        public int SayfaSayısı { get; set; }
        [Required]
        public string Yayınevi { get; set; }
        [Required]
        public string Yazar { get; set; }
        [Required]
        public int BasımYılı { get; set; }
        [Required]
        public int CiltNo { get; set; }
        public string ImageUrl { get; set; }
    }
}
