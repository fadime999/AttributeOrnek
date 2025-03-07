using System.ComponentModel.DataAnnotations;
using DefinexAttributeOrnek;

namespace WebApplication1.Models
{
    public class OgrenciModel
    {
        [Required]
        public string Adi { get; set; }

        [ZorunluAlan]
        public string Soyadi { get; set; }

        [ZorunluAlan]
        public string Bolum { get; set; }
    }
}