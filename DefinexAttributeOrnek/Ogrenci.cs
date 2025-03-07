using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinexAttributeOrnek
{
    public class Ogrenci
    {
        [Required]
        public string Adi;
        [ZorunluAlan]
        public string Soyadi;
        [ZorunluAlan]
        public string Bolum;
    }
}
