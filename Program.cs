using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(1, "Tayfun", "DEMİR");
            musteriManager.Ekle(2, "Mustafa", "DEMİR");
            musteriManager.Ekle(3, "Yusuf", "YILDIZ");

            Console.WriteLine("*********************************");

            musteriManager.Guncelle(1, "Barış", "MANÇO");
            musteriManager.Guncelle(2, "Ferdi", "TAYFUR");
            musteriManager.Guncelle(3, "Nejat", "UYGUR");

            Console.WriteLine("*********************************");

            musteriManager.Sil(0, "", "");
            musteriManager.Sil(0, "", "");
            musteriManager.Sil(0, "", "");

            Console.WriteLine("*********************************");
        }
    }
}
