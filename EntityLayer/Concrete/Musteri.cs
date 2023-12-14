using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Mail { get; set; }
        public string? TelefonNo { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Parola { get; set; }
        public bool Rol { get; set; }
        public List<Rezervasyon>? Rezervasyonlar {get; set;}

    }
}