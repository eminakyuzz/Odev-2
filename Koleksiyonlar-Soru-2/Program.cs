using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] sayılar = SayıGir();
            Sırala(sayılar);

            int[] enKucukUc = EnKucukUc(sayılar);
            Array.Reverse(sayılar);
            int[] enBuyukUc = EnKucukUc(sayılar);

            Console.WriteLine("En Küçük Sayılar Ortalaması :"+Ortalama(enKucukUc));
            Console.WriteLine("En BüyüK Sayılar Ortalaması :"+ Ortalama(enBuyukUc));

            var result = Ortalama(enBuyukUc) + Ortalama(enKucukUc);
            Console.WriteLine("Ortalamalar Toplamı :" + result);
    
        }

        static int[] SayıGir()
        {
            int sınır = 20;
            int[] dizi = new int[sınır];
            for (int i = 0; i < sınır; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz :", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            return dizi;
        }
        static int[] Sırala(int[] dizi) 
        {
            Array.Sort(dizi);
            return dizi ;
        }

        static int[] EnKucukUc(int[] dizi)
        {
            int[] enKucuk = new int[3];
            for (int i = 0; i < 3; i++)
            {
                enKucuk[i] = dizi[i];
            }
            return enKucuk;
        }

        static int Ortalama(int[] dizi)
        {
            int toplam = 0;
            int ortalama = 0;
            foreach (int item in dizi)
            {
                toplam += item ;
            }
            ortalama = toplam / dizi.Length ;
            return ortalama;
        }
    }
}
