using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sinemaPrjj
{
    class Adres
    {
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public string Cadde { get; set; }
        public Adres AdresEkle(int i)
        {
            if (i==1)
            {
                Adres adres = new Adres();
                adres.Cadde = "e5";
                adres.Mahalle = "saha";
                adres.Sokak = "fazıl";
                return adres;
            }
            if (i==2)
            {
                Adres adres = new Adres();
                adres.Cadde = "e10";
                adres.Mahalle = "halı";
                adres.Sokak = "kilim";
                return adres;

            }
            if (i == 3)
            {
                Adres adres = new Adres();
                adres.Cadde = "e100";
                adres.Mahalle = "sehpa";
                adres.Sokak = "koltuk";
                return adres;

            }

            else
            {
                Adres bos = new Adres();
                return bos; 
            }
        }

    }
}

