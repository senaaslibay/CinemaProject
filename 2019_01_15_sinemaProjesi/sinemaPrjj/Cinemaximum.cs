using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sinemaPrjj
{
    class Cinemaximum
    {
        public int CinemaxID { get; set; }
        public ArrayList Sinemalar { get; set; } = new ArrayList();
        public Sinema SinemaSec(int i)
        {
            Adres adres = new Adres();

            if (i == 1)
            {
                Sinema sinema1 = new Sinema();
                sinema1.SinemaAd = "Piazza";
                sinema1.SinemaID = 1;
                sinema1.Filmler = sinema1.FilmEkle(1);
                sinema1.SinemaAdres = adres.AdresEkle(1);
                Sinemalar.Add(sinema1);
                return sinema1;
            }

            if (i == 2)
            {
                Sinema sinema2 = new Sinema();
                sinema2.SinemaAd = "Trump Tower";
                sinema2.SinemaID = 2;
                sinema2.Filmler = sinema2.FilmEkle(2);
                sinema2.SinemaAdres = adres.AdresEkle(2);
                Sinemalar.Add(sinema2);
                return sinema2;
            }

            if (i == 3)
            {
                Sinema sinema3 = new Sinema();
                sinema3.SinemaAd = "Piazza";
                sinema3.SinemaID = 3;
                sinema3.Filmler = sinema3.FilmEkle(3);
                sinema3.SinemaAdres = adres.AdresEkle(3);
                Sinemalar.Add(sinema3);
                return sinema3;
            }

            else
            {
                Sinema sinemaBos = new Sinema();
                return sinemaBos;
            }
        }
        
        public void SinemalariGoster()
        {
            Adres adres = new Adres();

            Sinema sinema1 = new Sinema();
            sinema1.SinemaAd = "Piazza";
            sinema1.SinemaID = 1;
            sinema1.Filmler = sinema1.FilmEkle(1);
            sinema1.SinemaAdres = adres.AdresEkle(1);
            Sinemalar.Add(sinema1);




            Sinema sinema2 = new Sinema();
            sinema2.SinemaAd = "Trump Tower";
            sinema2.SinemaID = 2;
            sinema2.Filmler = sinema2.FilmEkle(2);
            sinema2.SinemaAdres = adres.AdresEkle(2);
            Sinemalar.Add(sinema2);



            Sinema sinema3 = new Sinema();
            sinema3.SinemaAd = "Tepe Nautilus";
            sinema3.SinemaID = 3;
            sinema3.Filmler = sinema3.FilmEkle(3);
            sinema3.SinemaAdres = adres.AdresEkle(3);
            Sinemalar.Add(sinema3);


            foreach (var item in Sinemalar)
            {
                Console.WriteLine($"Sinema Adı: {((Sinema)item).SinemaAd}");
                Console.WriteLine($"Sinema Numarası: {((Sinema)item).SinemaID} ");
                Console.Write($"{((Sinema)item).SinemaAdres.Cadde} Caddesi ");
                Console.Write($"{ ((Sinema)item).SinemaAdres.Mahalle} Mahallesi ");
                Console.Write($"{ ((Sinema)item).SinemaAdres.Sokak} Sokağı");
                Console.WriteLine();
                Console.WriteLine();


            }
        }

        //public Cinemaximum SinemaEkle(Cinemaximum cinemaximum)
        //{
        //    Console.WriteLine("Sinema ID numarasını giriniz.");
        //    int sec = int.Parse(Console.ReadLine());

        //    foreach (var item in cinemaximum.Sinemalar) 
        //    {
        //        cinemaximum.CinemaxID.CompareTo(item);
        //    }






        //}
    }

}
