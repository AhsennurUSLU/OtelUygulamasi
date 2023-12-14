using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Otel
    {
        [Key]
        public int OtelID { get; set; }
        public string OtelAd { get; set; }
        public string OtelBolge { get; set; }
        public string OtelAciklama { get; set; }
        public int OtelOdaSayisi { get; set; }
        public bool OtelDurum { get; set; }// aktif,pasif
    }
}
