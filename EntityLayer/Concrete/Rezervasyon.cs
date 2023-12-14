using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervasyon
    {
        [Key]
        public int RezervasyonID { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        public int Tutar { get; set; }
        public Otel SecilenOtel { get; set; }
        public Oda SecilenOda { get; set; } 
        public bool RezervasyonDurum { get; set; } 


    }
}
