using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //yaz();
            //yazz();
            topla();
            Console.ReadLine();
        }

        //static void yaz() //“Merhaba” metnini bir terimle hafızaya alıp, hafızaya alınan terimle yazdırma yöntemi.
        //{
        //    Console.WriteLine("Hello World!");
        //    Console.ReadLine();
        //}

        //static void yazz() //“Merhaba” metnini bir terimle hafızaya alıp, kullanıcının istediği adette hafızaya alınan terimle yazdırma yöntemi.
        //{
        //    Console.WriteLine("Mesajınızı giriniz");
        //    string mesaj = Console.ReadLine();
        //    Console.WriteLine("Ekranda mesajınız kaç kere görülsün?");
        //    int adet = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < adet; i++)
        //    {
        //        Console.WriteLine(mesaj);
        //    }
        //}

        static void topla()
        {
            int toplam = 0;
            Console.WriteLine("Toplama yapmak istediğiniz 1. sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplama yapmak istediğiniz 2. sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam="+toplam);
        }
    }
}
