using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Enes";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Enes Kaplan";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Engin Demiroğ";
            kurs2.İzlenmeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Furkan Yakut";
            kurs3.İzlenmeOrani = 32;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Sadık Turan";
            kurs4.İzlenmeOrani = 100;



            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni );
            }



            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int İzlenmeOrani { get; set; }
        
    }
}
