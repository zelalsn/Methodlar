﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi : "+ urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokaAdedi)
        {
            Console.WriteLine("sepete eklendi : "+ urunAdi);
        }
    }
}
