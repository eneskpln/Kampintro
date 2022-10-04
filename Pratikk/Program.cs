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
            kitap1.Yayini = yayin;

            Kitaplar kitap2 = new Kitaplar();
            kitap2.kitapAdi = "Suç ve Ceza";
            kitap2.Yazari = dosto;
            kitap2.sayfaSayisi = 638;
            kitap2.Yayini = yayin;

            Kitaplar kitap3 = new Kitaplar();
            kitap3.kitapAdi = "Sefiller";
            kitap3.Yazari = "Victor Hugo";
            kitap3.sayfaSayisi = 538;
            kitap3.Yayini = yayin;

            Kitaplar kitap4 = new Kitaplar();
            kitap4.kitapAdi = "Öteki";
            kitap4.Yazari = dosto;
            kitap4.sayfaSayisi = 238;
            kitap4.Yayini = yayin;

            Kitaplar[] kitaps = new Kitaplar[] { kitap1, kitap2, kitap3, kitap4 };

            foreach (var dongu in kitaps)
            {
                Console.WriteLine("Kitap Adı: " + dongu.kitapAdi + "\n" + "Yazarı: " + dongu.Yazari + "\n" + "Sayfa Sayısı: " + dongu.sayfaSayisi + "\n" + "Yayınevi: " + dongu.Yayini);
                Console.WriteLine("*");
            }


        }
    }



    class Kitaplar
    {
        public string kitapAdi { get; set; }
        public string Yazari { get; set; }
        public int sayfaSayisi { get; set; }
        public string Yayini { get; set; }
    }
}
