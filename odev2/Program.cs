using System;

class Program
{
    public static void Main(string[] args)
    {
        Product urun1 = new Product();  //İlk ürünümüzün bilgilerini tanımladık.
        urun1.urunAdi = "USB Çoğaltıcı";
        urun1.urunFiyati = 129.99;
        urun1.kullanilmaDurumu = "Sıfır";
        urun1.urunGarantisi = "2 Yıl Garanti";

        Product urun2 = new Product();  //İkinici ürünümüzün bilgilerini tanımladık.
        urun2.urunAdi = "Bluetooth Hoparlör";
        urun2.urunFiyati = 149.99;
        urun2.kullanilmaDurumu = "Sıfır";
        urun2.urunGarantisi = "2 Yıl Garanti";

        Product urun3 = new Product();  //Üçüncü ürünümüzün bilgilerini tanımladık.
        urun3.urunAdi = "Laptop Çantası";
        urun3.urunFiyati = 199.99;
        urun3.kullanilmaDurumu = "İkinci el";
        urun3.urunGarantisi = "Garantisi Yok";


        Product[] urunler = new Product[] { urun1, urun2, urun3 }; //Ürünlerimizi liste olarak tanımladık.

        //foreach (var mallar in urunler)
        //{
        //Console.WriteLine(mallar.urunAdi + " : " + mallar.urunFiyati + " " + mallar.kullanilmaDurumu + " + " + mallar.urunGarantisi);
        //}

        //for döngüsü ile aşağıdaki gibi ekrana yazdıralım.
        //for (int i = 0; i < urunler.Length; i++)  //Burada ürünlerin listesini oluşturduk.
        //{
        //    Console.WriteLine(urunler[i].urunAdi + " : " + urunler[i].urunFiyati + " , " + urunler[i].kullanilmaDurumu + " , " + urunler[i].urunGarantisi);

        //}

        //Aşağıdaki blokta ise while döngüsü ürünleri ekrana liste şeklinde yazdurdık.

        int j = 0;
        while (j < urunler.Length)
        
        {
            Console.WriteLine(urunler[j].urunAdi + " : " + urunler[j].urunFiyati + ", " + urunler[j].kullanilmaDurumu + ", " + urunler[j].urunGarantisi);

            j++;
        }






    }
}




class Product //Product isminde bir classs tanımlayıp ona ait özellikleri aşağıda belirttik.
{
    public string urunAdi { get; set; }

    public double urunFiyati { get; set; }

    public string kullanilmaDurumu { get; set; }

    public string urunGarantisi { get; set; }


}