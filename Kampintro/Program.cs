using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself = kendini tekrar etme
            //Aşağıdaki işlemi kolay hale getirebilmek için bu işleme isim veriyoruz yani alias = değer tutucu

            string kategoriEtiketi = ("Kategoriler");
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;  //float gibi
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            //

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            


        }
    }
}
