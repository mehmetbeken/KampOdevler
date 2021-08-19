using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Mehmet";
            musteri1.Surname = "Beken";
            musteri1.Age = 23;
            musteri1.Job = "Student";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Hamza";
            musteri2.Surname = "Salla";
            musteri2.Age = 44;
            musteri2.Job = "Police";

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Ayşe";
            musteri3.Surname = "Deneme";
            musteri3.Age = 33;
            musteri3.Job = "Engineer";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);



        }
    }
}
