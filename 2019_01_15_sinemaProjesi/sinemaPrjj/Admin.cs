using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemaPrjj
{
    class Admin
    {
        public string AdminName { get; set; }
        public string AdminPass { get; set; }

        public Admin MasterAdmin(Admin admin)
        {


            admin.AdminName = "Baris";
            admin.AdminPass = "14";

            return admin;
        }
        public void AdminGiris(Admin admin)
        {
            bool gir = false;
            do
            {
                
                Console.WriteLine("Admin Giriş Ekranı \n********************");
                Console.Write("Admin :");
                string admingir = Console.ReadLine();
                Console.Write("Sifre: ");
                string sifre = (Console.ReadLine());

                if (admingir == admin.AdminName && sifre == admin.AdminPass)
                {
                    Console.WriteLine("Giriş Başarılı");
                    gir = true;
                    
                }
                else
                {
                    Console.WriteLine("Giriş Başarısız");

                    Console.WriteLine("Tekrar Giriş yapmak ister misiniz? {(E)vet/(H)ayır}");
                    string sec = Console.ReadLine();
                    if (sec.ToUpper() == "E")
                        gir = false;
                    else
                        Environment.Exit(0);
                }


            } while (gir == false);



        }



    }
}
