using System;

namespace Pratikk
{
    class Program
    {
        static void Main(string[] args)
        {
            string yayin = "Türkiye İş Bankası Kültür Yayınları";
            string dosto = "Fyodor Mihayloviç Dostoyevski";

            Kitaplar kitap1 = new Kitaplar();
            kitap1.kitapAdi = "Kamelyalı Kadın";
            kitap1.Yazari = "Alexandre Dumas Fils";
            kitap1.sayfaSayisi = 238;
            kitap1.yayinEvi = yayin;

            Kitaplar kitap2 = new Kitaplar();
            kitap2.kitapAdi = "Sefiller";
            kitap2.Yazari = "Victor Hugo";
            kitap2.sayfaSayisi = 338;
            kitap2.yayinEvi = yayin;

            Kitaplar kitap3 = new Kitaplar();
            kitap3.kitapAdi = "Satranç";
            kitap3.Yazari = "Stefan Zweig";
            kitap3.sayfaSayisi = 98;
            kitap3.yayinEvi = yayin;

            Kitaplar kitap4 = new Kitaplar();
            kitap4.kitapAdi = "Kumarbaz";
            kitap4.Yazari = dosto;
            kitap4.sayfaSayisi = 256;
            kitap4.yayinEvi = yayin;

            Kitaplar kitap5 = new Kitaplar();
            kitap5.kitapAdi = "Öteki";
            kitap5.Yazari = dosto;
            kitap5.sayfaSayisi = 289;
            kitap5.yayinEvi = yayin;

            Kitaplar[] kitaps = new Kitaplar[] { kitap1, kitap2, kitap3, kitap4, kitap5 };

            Console.WriteLine("-------Kitaplar-------");
            Console.WriteLine(" ");

            foreach (var donek in kitaps)
            {
                Console.WriteLine("==> Kitap Adı: " + donek.kitapAdi + "\n" + "==> Yazarı: " + donek.Yazari + "\n" + "==> Sayfa Sayısı: " + donek.sayfaSayisi + "\n" + "==> Yayınevi: " + donek.yayinEvi);
                Console.WriteLine("*");
            }



        }
    }





    class Kitaplar
    {
        public string kitapAdi { get; set; }
        public string Yazari { get; set; }
        public int sayfaSayisi { get; set; }
        public string yayinEvi { get; set; }
    }
}
