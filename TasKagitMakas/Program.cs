
using System;

namespace TasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {

            string b, ç, t = "Taş", k = "Kağıt", m = "Makas";
            int kaz = 0;
            int kay = 0;
            int top = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Başak Seç >>>> Taş,Kağıt,Makas ");
                b = Console.ReadLine();
                Console.WriteLine("Çağatay Seç >>>> Taş,Kağıt,Makas ");
                ç = Console.ReadLine();

                if (b == t && ç == t)
                {
                    Console.WriteLine("Berabere!");
                }
                else if (b == k && ç == k)
                {
                    Console.WriteLine("Berabere!");
                }
                else if (b == m && ç == m)
                {
                    Console.WriteLine("Berabere!");
                }

                else if (b == t && ç == m)
                {
                    Console.WriteLine("Başak Kazandı!");
                    kaz++;
                }
                else if (b == t && ç == k)
                {
                    Console.WriteLine("Çağatay Kazandı!");
                    kay++;
                }
                else if (b == m && ç == t)
                {
                    Console.WriteLine("Çağatay Kazandı!");
                    kay++;
                }
                else if (b == m && ç == k)
                {
                    Console.WriteLine("Başak Kazandı!");
                    kaz++;
                }
                else if (b == k && ç == m)
                {
                    Console.WriteLine("Çağatay Kazandı!");
                    kay++;
                }
                else if (b == k && ç == t)
                {
                    Console.WriteLine("Başak Kazandı");
                    kaz++;
                }
                else
                {
                    Console.WriteLine("Değer Gir!");
                }
                top = kaz + kay;
            }
            Console.WriteLine("Başak - Çağatay arasında toplam {0} oyun oynandı.",top);
            Console.WriteLine("Başak Çağatayı {0} kere yendi", kaz);
            Console.WriteLine("Çağatay Başağı {0} kere yendi", kay);


            Console.ReadKey();

        }
    }
}
