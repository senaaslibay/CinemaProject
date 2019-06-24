using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sinemaPrjj
{
    class Film
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public string FilmmTuru { get; set; }
        public int FilmYasSiniri { get; set; }
        public int FilmFiyat { get; set; }
        public int FilmGise { get; set; }
        public int FilmSalon { get; set; }
        public Salon SalonEkle(int i)
        {
            ArrayList salonlar = new ArrayList();
            Salon salon1 = new Salon();
            salon1.SalonID = 1;
            salon1.SalonKoltukSayisi = 120;
            salonlar.Add(salon1);

            Salon salon2 = new Salon();
            salon2.SalonKoltukSayisi = 100;
            salon2.SalonID = 2;
            salonlar.Add(salon2);

            Salon salon3 = new Salon();
            salon3.SalonKoltukSayisi = 80;
            salon3.SalonID = 3;
            salonlar.Add(salon3);
            
            Salon salon4 = new Salon();
            salon4.SalonKoltukSayisi = 100;
            salon4.SalonID = 4;
            salonlar.Add(salon4);


            foreach (var item in salonlar)
            {
                if (((Salon)item).SalonID==i)
                {
                    return (Salon)item;
                }
            }
            Salon bos = new Salon();
            return bos;
        }
        public void GiseHesapla(int i)
        {
            Sinema sinema = new Sinema();
            sinema.FilmiGoster(i);
        }

    }
}
