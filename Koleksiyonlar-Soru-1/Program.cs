using System;
using System.Collections;
namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayılar = new ArrayList();
            ArrayList asalOlmayanSayılar = new ArrayList();

            int sınır = 20;
            int[] sayılar = new int[20];
 
            for (int i = 0; i <sınır; i++)
             {
                 try
                 {
                    Console.WriteLine("Lütfen {0}. sayıyı giriniz :" , i+1);
                    sayılar[i] = int.Parse(Console.ReadLine());

                 }
                 catch (System.FormatException hata)
                 {
                    Console.WriteLine($"Error: {hata.Message}");
                    Console.WriteLine("Lütfen {0}. sayıyı giriniz :" , i+1);
                    sayılar[i] = int.Parse(Console.ReadLine());
                    
                 }
                 
                 
             }

            foreach (var item in sayılar)
            {
                int kontrol = 0;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0 )
                        kontrol++;
                    else if (item == 1)
                    {
                        kontrol++;
                    }
                }

                if (kontrol != 0)
                    asalOlmayanSayılar.Add(item);
                else
                    asalSayılar.Add(item);

            }

            // asalSayılar.Sort();
            // asalOlmayanSayılar.Sort();

            Sirala(asalSayılar);
            Sirala(asalOlmayanSayılar);

            Console.WriteLine("****** ASAL SAYILAR******");
            foreach (var item in asalSayılar)
            {
                Console.WriteLine(" "+item);
            }

            Console.WriteLine("******* ASAL OLMAYAN SAYILAR******");
            foreach (var item in asalOlmayanSayılar)
            {
                Console.WriteLine(" "+item);

            }



            var asalToplam = ArrayOrtalama(asalSayılar);
            var asalOlmayanToplam = ArrayOrtalama(asalOlmayanSayılar);

            Console.WriteLine("Asal Sayılar Ortalaması :"+asalToplam);
            Console.WriteLine("Asal Olmayan Sayılar Ortalaması :"+asalOlmayanToplam);


            Console.WriteLine("Asal Sayılar Eleman Sayısı :"+ArrayElemanSayisi(asalSayılar));
            Console.WriteLine("Asal Olamyan Eleman Sayısı :"+ArrayElemanSayisi(asalOlmayanSayılar));



        }
        static int ArrayOrtalama(ArrayList dizi)
        {
            int toplam = 0;
            int ortalama = 0;
            
            foreach (int item in dizi)
            {
                toplam += item ;
            }
            ortalama = toplam / (dizi.Count);

            return ortalama;
        }

        static int ArrayElemanSayisi(ArrayList dizi)
        {
            return dizi.Count;
        }

        static void Sirala(ArrayList dizi)
        {
            dizi.Sort();
        }

        // static void SayiAl(int[] sayilar)
        // {
        //     int sınır = 20;
        //     int[] sayılar = new int[20];

        //     for (int i = 0; i < sınır; i++)
        //     {
        //         Console.WriteLine("Lütfen {0}. sayıyı giriniz :" , i+1);
        //         sayilar[i] = int.Parse(Console.ReadLine());
     
        //     }

        // }


    }
}
