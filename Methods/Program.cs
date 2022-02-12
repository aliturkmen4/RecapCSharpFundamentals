using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //yaz();
            yazz();
            Console.ReadLine();
        }

        //static void yaz() //“Merhaba” metnini bir terimle hafızaya alıp, hafızaya alınan terimle yazdırma yöntemi.
        //{
        //    Console.WriteLine("Hello World!");
        //    Console.ReadLine();
        //}

        static void yazz() //“Merhaba” metnini bir terimle hafızaya alıp, kullanıcının istediği adette hafızaya alınan terimle yazdırma yöntemi.
        {
            Console.WriteLine("Mesajınızı giriniz");
            string mesaj = Console.ReadLine();
            Console.WriteLine("Ekranda mesajınız kaç kere görülsün?");
            int adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(mesaj);
            }
        }
    }
}
