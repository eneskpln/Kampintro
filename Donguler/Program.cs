using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazıım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            //array = dizi yani liste tanımlama

            string[] kurslar = new string[] { "Yazıım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python Kursu", "C#"};
            


            for (int i = 0; i < kurslar.Length; i++) //Artıtma şekilleri => (i=i+1), (i+=2 iki iki arttır), (i++  bir bir arttır)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine(" ");
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
