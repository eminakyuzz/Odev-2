using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = CumleAl();
            string[] bulunanSesliHarfler = SesliHarfKontrol(cumle);

            foreach (var item in bulunanSesliHarfler)
            {
                Console.Write(item);
            }
            
        }

        static string CumleAl()
        {
            Console.WriteLine("Lütfen Bir Cümle Giriniz :");
            string cumle = Console.ReadLine() ;
            return cumle;
        }

        static string[] SesliHarfKontrol(string cumle)
        {
            string[] sesliHarfler ={"a","e","ı","i","o","ö","u","ü"};
            string[] bulunanSesliHarfler = new string[8] ;

            for (int i = 0; i < sesliHarfler.Length; i++)
            {
                bool v = cumle.Contains(sesliHarfler[i]);
                if (v == true)
                {
                    bulunanSesliHarfler[i] = sesliHarfler[i];
                }

            }
            return bulunanSesliHarfler;
        }
    }
}
