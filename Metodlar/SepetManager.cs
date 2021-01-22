using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi.");
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine(urunAdi + " Sepete Eklendi.");
        }
    }
}
