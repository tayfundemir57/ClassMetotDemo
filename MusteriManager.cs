using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void Ekle(int ıd, string ad, string soyad )
        {

            Console.WriteLine(ıd + " " + ad + " " + soyad + " ---" + "Ekleme İşlemi Yapıldı.");

        }


        public void Guncelle(int ıd, string ad, string soyad)
        {

            Console.WriteLine(ıd + " " + ad + " " + soyad +" ---" + "Güncelleme İşlemi Yapıldı.");

        }

        public void Sil(int ıd, string ad, string soyad)
        {

            Console.WriteLine(ıd + " " + ad + " " + soyad+" ---" + "Silinme İşlemi Yapıldı.");

        }

    }
}
