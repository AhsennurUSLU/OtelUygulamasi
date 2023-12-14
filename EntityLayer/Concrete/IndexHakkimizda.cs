using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class IndexHakkimizda
    {
        [Key]
        public int IndexHakkimizdaID{ get; set; } 
        public string ? IndexHakkimizdaBaslik { get; set; }
        public string ? IndexHakkimizdaAciklama { get; set; }
    }
}
