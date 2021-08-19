using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler,Müşteri Sisteme Başarıyla Kaydedildi,Aramıza Hoşgeldin" + " : " + musteri.Name);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi,Tekrar Görüşmek Dileğiyle" + " : " + musteri.Name);
        }
        public void MusteriListele(Musteri[] musteri)
        {
            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Name + " + " + musteriler.Surname + " + " +musteriler.Age + " + " +musteriler.Job);
            }
        }     
        }
    }

