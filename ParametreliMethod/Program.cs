using System;

namespace ParametreliMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            topla();
            topla(5, 6);
            topla(5, 6, 7);
            yaz("merhaba dünya",6,8);
            yazdır("ali");
            Console.WriteLine("Üstü alınacak sayıyı girin:");
            int sayi4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Üstü girin:");
            int us = int.Parse(Console.ReadLine());
            ustalma(sayi4, us);
            Console.WriteLine("Hacmini hesaplamak istediğinizi(1-Üçgen prizması 2-Silindir 3-Dikdörtgenler prizması) sayısal olarak seçiniz");
            int islem = int.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    Console.WriteLine("Taban giriniz:");
                    float taban = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yüksekliği giriniz:");
                    float yukseklik = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yüksekliği giriniz:");
                    float yukseklik1 = Convert.ToInt32(Console.ReadLine());
                    ucgen(taban, yukseklik, yukseklik1);
                    break;

                case 2:
                    Console.WriteLine("Yarıçapı giriniz:");
                    float r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yüksekliği giriniz:");
                    float h = Convert.ToInt32(Console.ReadLine());
                    silindir(r,h);
                    break;

                case 3:
                    Console.WriteLine("Kısa kenarı giriniz:");
                    float kisakenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Uzun kenarı giriniz:");
                    float uzunkenar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yüksekliği giriniz:");
                    float yukseklik2 = Convert.ToInt32(Console.ReadLine());
                    dikdortgen(kisakenar, uzunkenar,yukseklik2);
                    break;

            }
            Console.ReadLine();         
        }
        #region ıntro1
        static void yaz(string mesaj, int sayi1, int sayi2) //Aşağıdaki kod ile program ekrana merhaba dünya ve 14 yazar!
        {
            Console.WriteLine(mesaj);
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        } 
        #endregion

        #region istediğinkadarmesajyazdırma
        static void yazdır(string mesaj2) //Kullanıcının girdiği mesajı kullanıcının istediği kadar ekrana yazdıran program.
        {
            Console.WriteLine("Ekrana mesajı kaç kez basmak istersiniz?");
            int sayi3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi3; i++)
            {
                Console.WriteLine(mesaj2);
            }
        } 
        #endregion

        #region üstalma
        static void ustalma(int sayi4, int us) //Kullanıcı sayı ve bu sayının üs kuvvetini girecek. İşlemin sonucunu ekrana yazan program.
        {
            double sonuc = Math.Pow(sayi4, us);
            Console.WriteLine("sonuç=" + sonuc);
        }
        #endregion

        #region hacimhesabı
        static void ucgen(float taban, float yukseklik, float yukseklik1) //Üçgen prizma, silindir ve dikdörtgenler prizmasının hacmini parametre yöntemiyle hesaplayan program.
        {
            Console.WriteLine("Üçgen prizmanın hacmi=" + (taban * yukseklik * yukseklik1) / 6);
        }
        static void silindir(float r, float h)
        {
            Console.WriteLine("Siindirin hacmi=" + (Math.PI * r * r * h));
        }
        static void dikdortgen(float kisakenar, float uzunkenar, float yükseklik2)
        {
            Console.WriteLine("Dikdörtgenler prizmasının hacmi=" + (uzunkenar * kisakenar * yükseklik2));
        } 
        #endregion

        static void topla() //Üç adet ayrı ayrı topla komutları yazılacak (metodlu yöntemle).
        {
            Console.WriteLine("1.sayıyı giriniz:");
            float s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            float s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3.sayıyı giriniz:");
            float s3 = int.Parse(Console.ReadLine());
            float sum = s1 + s1 + s3;
            Console.WriteLine("Toplam:"+sum);
        }
        static void topla(int s1,int s2)
        {
            Console.WriteLine("Int sayıları toplamı:"+(s1+s2));
        }

        static void topla(double s1, int s2, short s3)
        {
            Console.WriteLine("Farklı türden sayıların toplamı:"+(s1+s2+s3));
        }
    }
}
