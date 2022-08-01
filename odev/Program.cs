using System;

class Program
{
    public static void Main(string[] args)
    {
        Product urun1 = new Product();
        urun1.urunAdi = "USB Çoğaltıcı";
        urun1.urunFiyati = 129.99;
        urun1.kullanilmaDurumu = "Sıfır";
        urun1.urunGarantisi = "2 Yıl Garanti";

        Product urun2 = new Product();
        urun2.urunAdi = "Bluetooth Hoparlör";
        urun2.urunFiyati = 149.99;
        urun2.kullanilmaDurumu = "Sıfır";
        urun2.urunGarantisi = "2 Yıl Garanti";

        Product urun3 = new Product();
        urun3.urunAdi = "Laptop Çantası";
        urun3.urunFiyati = 199.99;
        urun3.kullanilmaDurumu = "İkinci el";
        urun3.urunGarantisi = "Yok";


        Product[] urunler = new Product[] {urun1, urun2, urun3 };

        foreach (var mallar in urunler)
        {
            Console.WriteLine(mallar.urunAdi + " : " +  mallar.urunFiyati + " + " + mallar.urunGarantisi);
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