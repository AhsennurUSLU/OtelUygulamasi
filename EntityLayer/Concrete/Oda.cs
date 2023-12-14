using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Oda
    {
        [Key]
        public int OdaID { get; set; }
        [ForeignKey ("Otel")]
        public int OtelID { get; set; }

        public int OdaKapasite {  get; set; }
        public bool OdaDurum {  get; set; } //boş, dolu
        public int GunlukFiyat  { get; set; }
        //public String OdaTur {  get; set; } // ekonomik, standart, lüks
    }
}
