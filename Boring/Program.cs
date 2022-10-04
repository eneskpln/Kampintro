using System;

namespace Boring
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyunlar oyun1 = new Oyunlar();
            oyun1.oyunAdi = "ATV Motorcu";
            oyun1.bolumSayisi = 12;
            oyun1.zorlukDerecesi = "Orta";
            oyun1.Kategori = "Motor Oyunları";

            Oyunlar oyun2 = new Oyunlar();
            oyun2.oyunAdi = "DAĞ Arabası 2";
            oyun2.bolumSayisi = 15;
            oyun2.zorlukDerecesi = "Orta";
            oyun2.Kategori = "Araba Oyunları";

            Oyunlar oyun3 = new Oyunlar();
            oyun3.oyunAdi = "Fireman 2";
            oyun3.bolumSayisi = 20;
            oyun3.zorlukDerecesi = "Zor";
            oyun3.Kategori = "Beceri Oyunları";

            Oyunlar oyun4 = new Oyunlar();
            oyun4.oyunAdi = "Kaktüs McCoy 2";
            oyun4.bolumSayisi = 25;
            oyun4.zorlukDerecesi = "Zor";
            oyun4.Kategori = "Hikayeli Oyunlar";

            Oyunlar oyun5 = new Oyunlar();
            oyun5.oyunAdi = "Candy Crush Saga";
            oyun5.bolumSayisi = 1000;
            oyun5.zorlukDerecesi = "Orta";
            oyun5.Kategori = "Beceri Oyunları";

            Oyunlar oyun6 = new Oyunlar();
            oyun6.oyunAdi = "Okçu Adam";
            oyun6.bolumSayisi = 100;
            oyun6.zorlukDerecesi = "Zor";
            oyun6.Kategori = "Beceri Oyunları";

            Oyunlar oyun7 = new Oyunlar();
            oyun7.oyunAdi = "Savaş Stratejisi Oyunu";
            oyun7.bolumSayisi = 20;
            oyun7.zorlukDerecesi = "Zor";
            oyun7.Kategori = "Strateji Oyunları";



            Oyunlar[] oyunlar = new Oyunlar[] { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7 };

            foreach (var dongu in oyunlar)
            {
                Console.WriteLine("* " + dongu.oyunAdi + " ==> " + dongu.bolumSayisi + ", " + dongu.zorlukDerecesi + ", " + dongu.Kategori);
                Console.WriteLine(" ");
            }

            //for (int i = 0; i < oyunlar.Length; i++)
            //{
            //    Console.WriteLine(oyunlar[i].oyunAdi + " ==> " + oyunlar[i].bolumSayisi + ", " + oyunlar[i].zorlukDerecesi + ", " + oyunlar[i].Kategori);
            //}

            //int j = 0;
            //while (j < oyunlar.Length)
            //{
            //    Console.WriteLine(oyunlar[j].oyunAdi + " ==> " + oyunlar[j].bolumSayisi + ", " + oyunlar[j].zorlukDerecesi + ", " + oyunlar[j].Kategori);
            //    j++;
            //}






        }
    }
    class Oyunlar
    {
        public string oyunAdi { get; set; }
        public string zorlukDerecesi { get; set; }
        public int bolumSayisi { get; set; }
        public string Kategori { get; set; }
    }

}