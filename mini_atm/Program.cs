using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 2000;
            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.Write("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("\n\n 1- Bakiye  Görüntüleme \n 2- Para Çekme \n 3- Para Yatırma\n\nÇıkmak için q'ya basın. ");
            int tutar;

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Bakiyeniz görünütüleniyor ..." + bakiye);
            }
            else if (secim == "2")
            {
                Console.Write("Çekmek istediğiniz tutarı giriniz : ");
                int cekilecek_para = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_para > bakiye)
                {
                    Console.Write("Girdiğiniz tutar bakiyenizi aşıyor. Lütfen bakiyenize göre bir tutar giriniz !");
                    Console.Read();
                    Environment.Exit(0);
                }
                tutar = (bakiye - cekilecek_para);
                Console.Write("Kalan Bakiyeniz : " + tutar);
            }
            else if (secim == "3")
            {
                Console.Write("Yatırmak istediğiniz tutarı giriniz : ");
                int yatirilacak_para = Convert.ToInt32(Console.ReadLine());
                tutar = (bakiye + yatirilacak_para);
                Console.Write("Güncel Bakiyeniz :" + tutar);
            }
            else if (secim == "q")
            {
                Console.Write("ATM'den çıkış yapılıyor..");
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                Console.Write("lütfen bir değer giriniz");
            }
            Console.Read();
        }
    }
}
