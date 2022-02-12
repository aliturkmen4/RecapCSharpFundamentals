using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            yaz();
            yazz();
            topla();
            tekcift();
            buyukkucuk();
            Console.ReadLine();
        }

        static void yaz() //“Merhaba” metnini bir terimle hafızaya alıp, hafızaya alınan terimle yazdırma yöntemi.
        {
            Console.WriteLine("Hello World!");
        }

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

        static void topla() //İki sayıyı toplayan metodu yazın. Sayıları kullanıcı tarafından girilecek.
        {
            int toplam = 0;
            Console.WriteLine("Toplama yapmak istediğiniz 1. sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplama yapmak istediğiniz 2. sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam="+toplam);
        }

        static void tekcift() //Girilen sayının tek mi çift mi olduğunu yazdıran metot.
        {
            Console.WriteLine("Tek çift olarak kontrol etmek istediğiniz sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi3 % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }
        }
        static void buyukkucuk()
        {
            Console.Write("1.sayıyı girin: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı girin: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("3.sayıyı girin: ");
            int s3 = int.Parse(Console.ReadLine());
            if (s1 > s2 && s1 > s3)
            {
                Console.WriteLine("en büyük sayı: " + s1);
            }
            if (s2 > s1 && s2 > s3)
            {
                Console.WriteLine("en büyük sayı: " + s2);
            }
            if (s3 > s1 && s3 > s2)
            {
                Console.WriteLine("en büyük sayı: " + s3);
            }
            if (s1 < s2 && s1 < s3)
            {
                Console.WriteLine("en küçük sayı: " + s1);
            }
            if (s2 < s1 && s2 < s3)
            {
                Console.WriteLine("en küçük sayı: " + s2);
            }
            if (s3 < s1 && s3 < s2)
            {
                Console.WriteLine("en küçük sayı: " + s3);
            }
        }

    }
}

