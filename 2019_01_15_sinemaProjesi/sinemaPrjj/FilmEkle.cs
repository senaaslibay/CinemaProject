using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace sinemaPrjj
{
    class FilmEkle
    {
        public ArrayList FilmEkleme { get; set; } = new ArrayList();
        public string yenifilmadi { get; set; }
        public string yenifilmtürü { get; set; }
        public int yenifilmfiyat { get; set; }
        public int yenifilmgise { get; set; }
        public int yenifilmID { get; set; }
        public int yenifilmSalon { get; set; }
        public int yenifilmyassiniri { get; set; }

        public ArrayList YeniFilmEkle(int i )
        {
            Film Filmekleme = new Film();
            Console.Write("Film adını giriniz:");
            string yenifilmadi = Console.ReadLine();
            FilmEkleme.Add(yenifilmadi);
            Console.Write("Film türünü giriniz:");
            string yenifilmtürü = Console.ReadLine();
            FilmEkleme.Add(yenifilmtürü);
            Console.Write("Film fiyat giriniz:");
            int yenifilmfiyat = int.Parse(Console.ReadLine());
            FilmEkleme.Add(yenifilmfiyat);
            Console.Write("Film gişe giriniz:");
            int yenifilmgise = int.Parse(Console.ReadLine());
            FilmEkleme.Add(yenifilmgise);
            Console.Write("Film ID giriniz:");
            int yenifilmID = int.Parse(Console.ReadLine());
            FilmEkleme.Add(yenifilmID);
            Console.Write("Film Salon giriniz:");
            int yenifilmSalon = int.Parse(Console.ReadLine());
            FilmEkleme.Add(yenifilmSalon);
            Console.Write("Film Yaş sınırı giriniz:");
            int yenifilmyassiniri = int.Parse(Console.ReadLine());
            FilmEkleme.Add(yenifilmyassiniri);

            //FilmEkleme.AddRange(Filmekleme);

            return FilmEkleme;
        }

    }
}
