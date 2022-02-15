using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin2
{
    class Program
    {

        static Random rastgele = new Random();

        static void Main(string[] args)
        {
            int tahmin, sayi = rastgele.Next(100);
            int can = 10;
            
            while (true)
            {
                Console.WriteLine("\n\n" + can-- + "canınız kaldı.");
                if (can < 0)
                {
                    Console.WriteLine("Maalesef Kaybettiniz! Sayı : " + sayi);
                    break;
                }

                Console.Write("Sayı Giriniz : ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if(tahmin > sayi)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                }
                else if ( tahmin < sayi)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                }
                else
                {
                    Console.WriteLine("Tebrikler!!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
