using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace sinemaPrjj
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerID = 1;
            customer.CustomerAd = "Sena";
            customer.CustomerSoyad = "Aslıbay";
            customer.CustomerYas = 24;
            //-----------------------------------------------------------------------
                    Cinemaximum cinemaximum = new Cinemaximum();

            Console.WriteLine("Sinemaları Görüntülemek İçin 1'e");
            Console.WriteLine("Admin Girişi İçin 2'ye");
            Console.WriteLine("Çıkış İçin 3'e Basınız.");
            int anaMenuSecenek = int.Parse(Console.ReadLine());
            switch (anaMenuSecenek)
            {
                case 1:
                    cinemaximum.SinemalariGoster();

                    //----------------------------------------------------------------------------

                    Console.WriteLine($"Seçmek istediğiniz Sinemanın ID'sini giriniz.");
                    int sinemaSecenek = int.Parse(Console.ReadLine());
                    Sinema sinema = new Sinema();
                    switch (sinemaSecenek)
                    {
                        case 1:

                            sinema.FilmleriGoster(1);

                            break;
                        case 2:

                            sinema.FilmleriGoster(2);

                            break;
                        case 3:

                            sinema.FilmleriGoster(3);

                            break;
                    }
                    //------------------------------------------------------------------------------

                    Console.WriteLine("Seçmek istediğiniz Filmin ID'sini giriniz.");
                    int filmSecenek = int.Parse(Console.ReadLine());
                    switch (filmSecenek)
                    {
                        case 1:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                        case 2:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                        case 3:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                        case 4:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                        case 5:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                        case 6:
                            sinema.FilmiGoster(filmSecenek);
                            break;
                    }
                    //------------------------------------------------------------------


                    Film film = new Film();
                    Salon salon = new Salon();
                    Console.WriteLine($"Bilet Almak İçin 1'e");
                    Console.WriteLine($"Ana Sayfaya Dönmek İçin 2'ye basınız.");
                    int biletSecenek = int.Parse(Console.ReadLine());

                    switch (biletSecenek)
                    {
                        case 1:
                            film = sinema.FilmiSec(filmSecenek);

                            if (customer.CustomerYas > film.FilmYasSiniri)
                            {
                                if (customer.CustomerYas > 18)
                                {
                                    film.FilmGise = film.FilmGise + 20;
                                    salon = film.SalonEkle(filmSecenek);

                                    if (salon.SalonKoltukSayisi > 0)
                                    {
                                        salon.SalonKoltukSayisi--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bu filmin biletleri tükenmiş bulunmakta");
                                    }
                                }
                                else
                                {
                                    film.FilmGise = film.FilmGise + 15;
                                }
                            }
                            Console.WriteLine("Biletiniz Oluşturuldu");
                            Console.WriteLine(film.FilmGise);
                            Console.WriteLine(salon.SalonKoltukSayisi);




                            break;
                    }
                    break;
                case 2:
                    Admin admin = new Admin();

                    admin.MasterAdmin(admin);
                    admin.AdminGiris(admin);

                    

                    Console.WriteLine("Düzenleme Ekranı \n *****************");
                    Console.WriteLine("Film eklemek için 1'e");
                    Console.WriteLine("Film güncellemek için 2'e");
                    Console.WriteLine("Film silmek için 3'e");
                    Console.WriteLine("Çıkış için 4'e\n Basınız..");
                    string sec = Console.ReadLine();
                    switch (sec)
                    {
                        case "1":
                            Console.WriteLine("Film Ekleme");
                            
                            FilmEkle filmekle = new FilmEkle();
                            filmekle.YeniFilmEkle(1);





                            break;
                    }


                    break;
                case 3:

                    break;
            }

        }
    }
}
