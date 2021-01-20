using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "Hoşgeldiniz!");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "Tekrar Görüşmek Dileğiyle");
        }

    }
}
