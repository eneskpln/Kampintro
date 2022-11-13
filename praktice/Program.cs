using System;

namespace praktice
{
    class Program
    {
        static void Main(string[] args)
        {
            string yayin = "Türkiye İş Bankası Kültür Yyaınları";

            Kitaplar kitap1 = new Kitaplar();
            kitap1.kitapAdi = "Kamelyalı Kadın";
            kitap1.Yazari = "Alexandre Dumas Fils";
            kitap1.sayfaSayisi = 238;
            kitap1.Yayinevi = yayin;

            Kitaplar kitap2 = new Kitaplar();
            kitap2.kitapAdi = "Suç ve Ceza";
            kitap2.Yazari = "Fyodor Mihayloviç Dostoyevski";
            kitap2.sayfaSayisi = 659;
            kitap2.Yayinevi = yayin;

            Kitaplar kitap3 = new Kitaplar();
            kitap3.kitapAdi = "Kumarbaz";
            kitap3.Yazari = "Fyodor Mihayloviç Dostoyevski";
            kitap3.sayfaSayisi = 240;
            kitap3.Yayinevi = yayin;

            Kitaplar kitap4 = new Kitaplar();
            kitap4.kitapAdi = "Yeraltından Notlar";
            kitap4.Yazari = "Fyodor Mihayloviç Dostoyevski";
            kitap4.sayfaSayisi = 238;
            kitap4.Yayinevi = yayin;

            Kitaplar[] kitaps = new Kitaplar[] { kitap1, kitap2, kitap3, kitap4 };

            Console.WriteLine("--------Kitaplar--------");
            Console.WriteLine(" ");

            foreach (var dongu in kitaps)
            {
                Console.WriteLine("==> Kitap Adı: " + dongu.kitapAdi + "\n" + "==> Yazarı: " + dongu.Yazari + "\n" + "==> Sayfa Sayısı: " + dongu.sayfaSayisi + "\n" + "==> Yayınevi: " +dongu.Yayinevi );
                Console.WriteLine(" ");
            }
        }
    }

    class Kitaplar
    {
        public string kitapAdi { get; set; }
        public string Yazari { get; set; }
        public int sayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
    }
}
