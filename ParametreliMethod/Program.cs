using System;

namespace ParametreliMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            yaz("merhaba dünya",6,8);
            yazdır("ali");
            Console.ReadLine();
            
        }

        static void yaz(string mesaj,int sayi1,int sayi2) //Aşağıdaki kod ile program ekrana merhaba dünya ve 14 yazar!
        {
            Console.WriteLine(mesaj);
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        static void yazdır(string mesaj2) //Kullanıcının girdiği mesajı kullanıcının istediği kadar ekrana yazdıran program.
        {
            Console.WriteLine("Ekrana mesajı kaç kez basmak istersiniz?");
            int sayi3 = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < sayi3; i++)
            {
                Console.WriteLine(mesaj2);
            }
        }
    }
}
