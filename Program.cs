using System;

namespace dizi_ornekleri1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KULLANICIDAN DİZİ ELEMANLARINI AL VE EKRANA YAZDIR");
            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar dizisinin "+i+". elemanını giriniz: ");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());             
            }
            Console.WriteLine("Dizinin elemanlarını belirlediniz şimdi elemanları yazdırıyoruz..");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


        }
    }
}
