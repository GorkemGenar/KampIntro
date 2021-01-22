using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler onlara en başta verilen eleman sayısı kadar boyuta sahiptir. Sonradan bu boyut arttırılamaz.
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //isimler[4] = "Görkem"; // Dizi 4 elemanlı olduğu için bu atama sırsında hata verir.
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            isimler2.Add("Murat");
            isimler2.Add("Kerem");
            isimler2.Add("Halil");
            /*veya 
            List<string> isimler2 = new List<string>()
            {
                "Engin",
                "Murat",
                "Kerem",
                "Halil"
            };
            */
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Görkem");
            Console.WriteLine(isimler2[4]);

            Console.ReadLine();

        }
    }
}
