using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Mehmet";
            musteri1.MusteriSoyadi = "Aslan";
            musteri1.MusteriYasi = 43;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Gamze";
            musteri2.MusteriSoyadi = "Çiler";
            musteri2.MusteriYasi = 27;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Deniz";
            musteri3.MusteriSoyadi = "Adıgüzel";
            musteri3.MusteriYasi = 58;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriYasi);
                Console.WriteLine("---------------------");
            }
        }
    }
}
