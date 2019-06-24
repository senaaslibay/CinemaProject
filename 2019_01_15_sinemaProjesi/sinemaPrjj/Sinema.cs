using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sinemaPrjj
{
    class Sinema
    {
        public int SinemaID { get; set; }
        public string SinemaAd { get; set; }
        public Adres SinemaAdres { get; set; }
        public ArrayList Filmler { get; set; } = new ArrayList();
        public ArrayList FilmEkle(int i)
        {

            //Salon salon1 = new Salon();
            //salon1.SalonID = 1;
            //salon1.SalonKoltukSayisi = 120;

            if (i == 1)
            {
                ArrayList filmler1 = new ArrayList();
                Film film1 = new Film();
                film1.FilmFiyat = 20;
                film1.FilmAdi = "3 Idiots";
                film1.FilmGise = 0;
                film1.FilmID = 1;
                film1.FilmmTuru = "Komedi";
                film1.FilmSalon = film1.SalonEkle(1).SalonID;
                film1.FilmYasSiniri = 7;
                filmler1.Add(film1);

                //Salon salon2 = new Salon();
                //salon2.SalonKoltukSayisi = 100;
                //salon2.SalonID = 2;
                Film film2 = new Film();
                film2.FilmFiyat = 20;
                film2.FilmAdi = "21";
                film2.FilmGise = 0;
                film2.FilmID = 2;
                film2.FilmmTuru = "Aksiyon";
                film2.FilmSalon = film2.SalonEkle(2).SalonID;
                film2.FilmYasSiniri = 13;
                filmler1.Add(film2);
                return filmler1;
            }

            if (i == 2)
            {
                ArrayList filmler = new ArrayList();
                //Salon salon3 = new Salon();
                //salon3.SalonKoltukSayisi = 80;
                //salon3.SalonID = 3;
                Film film3 = new Film();
                film3.FilmFiyat = 20;
                film3.FilmAdi = "The Dark Knight";
                film3.FilmGise = 0;
                film3.FilmID = 3;
                film3.FilmmTuru = "Aksiyon";
                film3.FilmSalon = film3.SalonEkle(3).SalonID;
                film3.FilmYasSiniri = 13;
                filmler.Add(film3);

                //Salon salon4 = new Salon();
                //salon4.SalonKoltukSayisi = 100;
                //salon4.SalonID = 4;
                Film film4 = new Film();
                film4.FilmFiyat = 20;
                film4.FilmAdi = "Matrix";
                film4.FilmGise = 0;
                film4.FilmID = 4;
                film4.FilmmTuru = "Aksiyon";
                film4.FilmSalon = film4.SalonEkle(4).SalonID;
                film4.FilmYasSiniri = 13;
                filmler.Add(film4);
                return filmler;
            }

            if (i == 3)
            {
                ArrayList filmler = new ArrayList();
                //Salon salon3 = new Salon();
                //salon3.SalonKoltukSayisi = 80;
                //salon3.SalonID = 3;
                Film film5 = new Film();
                film5.FilmFiyat = 20;
                film5.FilmAdi = "The Dark Knight";
                film5.FilmGise = 0;
                film5.FilmID = 5;
                film5.FilmmTuru = "Aksiyon";
                film5.FilmSalon = film5.SalonEkle(5).SalonID;
                film5.FilmYasSiniri = 13;
                filmler.Add(film5);

                //Salon salon4 = new Salon();
                //salon4.SalonKoltukSayisi = 100;
                //salon4.SalonID = 4;
                Film film6 = new Film();
                film6.FilmFiyat = 20;
                film6.FilmAdi = "Matrix";
                film6.FilmGise = 0;
                film6.FilmID = 6;
                film6.FilmmTuru = "Aksiyon";
                film6.FilmSalon = film6.SalonEkle(6).SalonID;
                film6.FilmYasSiniri = 13;
                filmler.Add(film6);
                return filmler;
            }
            else
            {
                ArrayList filmlerbos = new ArrayList();
                return filmlerbos;
            }

        }
        public void FilmleriGoster(int i)
        {
            if (i == 1)
            {

                Film film1 = new Film();
                film1.FilmFiyat = 20;
                film1.FilmAdi = "3 Idiots";
                film1.FilmGise = 0;
                film1.FilmID = 1;
                film1.FilmmTuru = "Komedi";
                film1.FilmSalon = film1.SalonEkle(1).SalonID;
                film1.FilmYasSiniri = 7;
                Console.WriteLine($"Filmin ID: {film1.FilmID}");
                Console.WriteLine($"Filmin Adı: {film1.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film1.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film1.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film1.FilmYasSiniri}\n");


                Film film2 = new Film();
                film2.FilmFiyat = 20;
                film2.FilmAdi = "21";
                film2.FilmGise = 0;
                film2.FilmID = 2;
                film2.FilmmTuru = "Aksiyon";
                film2.FilmSalon = film2.SalonEkle(2).SalonID;
                film2.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film2.FilmID}");
                Console.WriteLine($"Filmin Adı: {film2.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film2.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film2.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film2.FilmYasSiniri}\n");


            }

            if (i == 2)
            {

                Film film3 = new Film();
                film3.FilmFiyat = 20;
                film3.FilmAdi = "The Dark Knight";
                film3.FilmGise = 0;
                film3.FilmID = 3;
                film3.FilmmTuru = "Aksiyon";
                film3.FilmSalon = film3.SalonEkle(3).SalonID;
                film3.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film3.FilmID}");
                Console.WriteLine($"Filmin Adı: {film3.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film3.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film3.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film3.FilmYasSiniri}\n");



                Film film4 = new Film();
                film4.FilmFiyat = 20;
                film4.FilmAdi = "Matrix";
                film4.FilmGise = 0;
                film4.FilmID = 4;
                film4.FilmmTuru = "Aksiyon";
                film4.FilmSalon = film4.SalonEkle(4).SalonID;
                film4.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film4.FilmID}");
                Console.WriteLine($"Filmin Adı: {film4.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film4.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film4.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film4.FilmYasSiniri}\n");


            }

            if (i == 3)
            {

                Film film5 = new Film();
                film5.FilmFiyat = 20;
                film5.FilmAdi = "Açlık Oyunları";
                film5.FilmGise = 0;
                film5.FilmID = 5;
                film5.FilmmTuru = "Aksiyon";
                film5.FilmSalon = film5.SalonEkle(5).SalonID;
                film5.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film5.FilmID}");
                Console.WriteLine($"Filmin Adı: {film5.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film5.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film5.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film5.FilmYasSiniri}\n");




                Film film6 = new Film();
                film6.FilmFiyat = 20;
                film6.FilmAdi = "Amelie";
                film6.FilmGise = 0;
                film6.FilmID = 6;
                film6.FilmmTuru = "Aksiyon";
                film6.FilmSalon = film6.SalonEkle(6).SalonID;
                film6.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film6.FilmID}");
                Console.WriteLine($"Filmin Adı: {film6.FilmAdi}\n");
                //Console.WriteLine($"Filmin Turu: {film6.FilmmTuru}");
                //Console.WriteLine($"Oynatılacağı Salon: {film6.FilmSalon}");
                //Console.WriteLine($"Yaş Sınırı: {film6.FilmYasSiniri}\n");


            }

        }
        public void FilmiGoster(int i)
        {
            if (i == 1)
            {

                Film film1 = new Film();
                film1.FilmFiyat = 20;
                film1.FilmAdi = "3 Idiots";
                film1.FilmGise = 0;
                film1.FilmID = 1;
                film1.FilmmTuru = "Komedi";
                film1.FilmSalon = film1.SalonEkle(1).SalonID;
                film1.FilmYasSiniri = 7;
                Console.WriteLine($"Filmin ID: {film1.FilmID}");
                Console.WriteLine($"Filmin Adı: {film1.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film1.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film1.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film1.FilmYasSiniri}\n");
            }

            if (i == 2)
            {
                Film film2 = new Film();
                film2.FilmFiyat = 20;
                film2.FilmAdi = "21";
                film2.FilmGise = 0;
                film2.FilmID = 2;
                film2.FilmmTuru = "Aksiyon";
                film2.FilmSalon = film2.SalonEkle(2).SalonID;
                film2.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film2.FilmID}");
                Console.WriteLine($"Filmin Adı: {film2.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film2.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film2.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film2.FilmYasSiniri}\n");

            }



            if (i == 3)
            {

                Film film3 = new Film();
                film3.FilmFiyat = 20;
                film3.FilmAdi = "The Dark Knight";
                film3.FilmGise = 0;
                film3.FilmID = 3;
                film3.FilmmTuru = "Aksiyon";
                film3.FilmSalon = film3.SalonEkle(3).SalonID;
                film3.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film3.FilmID}");
                Console.WriteLine($"Filmin Adı: {film3.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film3.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film3.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film3.FilmYasSiniri}\n");

            }


            if (i == 4)
            {
                Film film4 = new Film();
                film4.FilmFiyat = 20;
                film4.FilmAdi = "Matrix";
                film4.FilmGise = 0;
                film4.FilmID = 4;
                film4.FilmmTuru = "Aksiyon";
                film4.FilmSalon = film4.SalonEkle(4).SalonID;
                film4.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film4.FilmID}");
                Console.WriteLine($"Filmin Adı: {film4.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film4.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film4.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film4.FilmYasSiniri}\n");


            }

            if (i == 5)
            {

                Film film5 = new Film();
                film5.FilmFiyat = 20;
                film5.FilmAdi = "Açlık Oyunları";
                film5.FilmGise = 0;
                film5.FilmID = 5;
                film5.FilmmTuru = "Aksiyon";
                film5.FilmSalon = film5.SalonEkle(5).SalonID;
                film5.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film5.FilmID}");
                Console.WriteLine($"Filmin Adı: {film5.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film5.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film5.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film5.FilmYasSiniri}\n");


            }

            if (i == 6)
            {
                Film film6 = new Film();
                film6.FilmFiyat = 20;
                film6.FilmAdi = "Amelie";
                film6.FilmGise = 0;
                film6.FilmID = 6;
                film6.FilmmTuru = "Aksiyon";
                film6.FilmSalon = film6.SalonEkle(6).SalonID;
                film6.FilmYasSiniri = 13;
                Console.WriteLine($"Filmin ID: {film6.FilmID}");
                Console.WriteLine($"Filmin Adı: {film6.FilmAdi}");
                Console.WriteLine($"Filmin Turu: {film6.FilmmTuru}");
                Console.WriteLine($"Oynatılacağı Salon: {film6.FilmSalon}");
                Console.WriteLine($"Yaş Sınırı: {film6.FilmYasSiniri}\n");
            }

        }
        public Film FilmiSec(int i)
        {
            if (i == 1)
            {

                Film film1 = new Film();
                film1.FilmFiyat = 20;
                film1.FilmAdi = "3 Idiots";
                film1.FilmGise = 0;
                film1.FilmID = 1;
                film1.FilmmTuru = "Komedi";
                film1.FilmSalon = film1.SalonEkle(1).SalonID;
                film1.FilmYasSiniri = 7;
                return film1;
            
            }

            if (i == 2)
            {
                Film film2 = new Film();
                film2.FilmFiyat = 20;
                film2.FilmAdi = "21";
                film2.FilmGise = 0;
                film2.FilmID = 2;
                film2.FilmmTuru = "Aksiyon";
                film2.FilmSalon = film2.SalonEkle(2).SalonID;
                film2.FilmYasSiniri = 13;
                return film2;
            }



            if (i == 3)
            {

                Film film3 = new Film();
                film3.FilmFiyat = 20;
                film3.FilmAdi = "The Dark Knight";
                film3.FilmGise = 0;
                film3.FilmID = 3;
                film3.FilmmTuru = "Aksiyon";
                film3.FilmSalon = film3.SalonEkle(3).SalonID;
                film3.FilmYasSiniri = 13;
                return film3;

            }


            if (i == 4)
            {
                Film film4 = new Film();
                film4.FilmFiyat = 20;
                film4.FilmAdi = "Matrix";
                film4.FilmGise = 0;
                film4.FilmID = 4;
                film4.FilmmTuru = "Aksiyon";
                film4.FilmSalon = film4.SalonEkle(4).SalonID;
                film4.FilmYasSiniri = 13;
                return film4;



            }

            if (i == 5)
            {

                Film film5 = new Film();
                film5.FilmFiyat = 20;
                film5.FilmAdi = "Açlık Oyunları";
                film5.FilmGise = 0;
                film5.FilmID = 5;
                film5.FilmmTuru = "Aksiyon";
                film5.FilmSalon = film5.SalonEkle(5).SalonID;
                film5.FilmYasSiniri = 13;
                return film5;


            }

            if (i == 6)
            {
                Film film6 = new Film();
                film6.FilmFiyat = 20;
                film6.FilmAdi = "Amelie";
                film6.FilmGise = 0;
                film6.FilmID = 6;
                film6.FilmmTuru = "Aksiyon";
                film6.FilmSalon = film6.SalonEkle(6).SalonID;
                film6.FilmYasSiniri = 13;
                return film6;

            }
            else
            {
                Film filmBos = new Film();
                return filmBos;
            }

        }

    }
}
