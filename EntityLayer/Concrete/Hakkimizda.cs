﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; }
        public string HakkimizdaDetay { get; set; }
        public string  HakkimizdaGorsel { get; set; } 
        public bool  HakkimizdaDurum { get; set; }  
    }
}
