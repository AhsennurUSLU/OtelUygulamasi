using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PopulerOteller
    {
        [Key]
        public int OtelID { get; set; }
        public string Bolge { get; set; }
        public int Sayi { get; set; }
        public string Gorsel { get; set; }
        public bool Durum { get; set; }
    }
}
