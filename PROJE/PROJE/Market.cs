using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public class Market
    {
        public string MarketAdi { get; set; }

        public Adres MarketAdres { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<Personel> Personels { get; set; }

        public List<Tedarikci> Tedarikcis { get; set; }
      
   
        public Market()
        {
            this.MarketAdres = new Adres();
            this.Urunler = new List<Urun>();
            this.Personels = new List<Personel>();
            this.Tedarikcis = new List<Tedarikci>();

           
            TedarikciOlustur();
            PersoOlustur();
            UrunOlustur();

            
            
        }
        // Fonskiyonlar
        // Fonksiyonlar
        public void UrunEkle(Urun urun)
        {
            bool x = true;
            foreach (Urun u in Urunler)
            {

                if (u.barkodNo == urun.barkodNo)
                {
                    x = false;
                    u.stokSayisi = u.stokSayisi + urun.stokSayisi;
                }

            }


            if (x == true)
            {
                Urunler.Add(urun);

            }

        }
        public void UrunSil(Urun urun)
        {

            Urunler.Remove(urun);
        }
        public void PersoSil(Personel p)
        {
            Personels.Remove(p);

        }
        public void PersonelEkle(Personel perso)
        {
            Personels.Add(perso);
        }
        public void IndirimYap(Urun urun, float miktar)
        {
            foreach (Urun u in Urunler)
            {

                if (u.barkodNo == urun.barkodNo)
                {
                    u.Fiyat = u.Fiyat - (u.Fiyat * miktar / 100);
                    if (u.Fiyat < 0)
                        u.Fiyat = 0;
                    u.SonIndirim = DateTime.Now;
                }

            }
        }
        // Veri Oluşturma
        private void PersoOlustur()
        {

            this.MarketAdi = "YolSuz Market";
            this.MarketAdres.AcikAdres = "Esenlerde Biyerde";
            string date = "22/07/2020";// işin kuruldugu tarih
            Personel p1 = new Personel();
            Personel p2 = new Personel();
            Personel p3 = new Personel();
            Personel p4 = new Personel();
            Personel p5 = new Personel();
            Personel p6 = new Personel();
            Personel yonetici = new Personel();
            Personel yonetici2 = new Personel();
            yonetici.MaasHesapla(5000);
            yonetici.Isim = "Atakan";
            yonetici.Soyisim = "Him";
            yonetici.Tc = 1;
            yonetici.Telefon = 05554542132;
            yonetici.Departman = "Yonetici";
            yonetici.Tarih = DateTime.Parse(date);
            yonetici.Adres.AcikAdres = "Zeytinburnu son sokağın son yokuşun son dairenin son zili ";
            yonetici.Sube = "Bagcılar Market";

            yonetici2.MaasHesapla(5000);
            yonetici2.Isim = "Yunus";
            yonetici2.Soyisim = "Emre";
            yonetici2.Tc = 2;
            yonetici2.Telefon = 05554542132;
            yonetici2.Departman = "Yonetici";
            yonetici2.Tarih = DateTime.Parse(date);
            yonetici2.Adres.AcikAdres = "Zeytinburnu son sokağın son yokuşun son dairenin son zili ";
            yonetici2.Sube = "Esenler Market";


            p1.MaasHesapla(5000);
            p1.Isim = "Atakan";
            p1.Soyisim = "Kim";
            p1.Tc = 10;
            p1.Telefon = 05312551367;
            p1.Departman = "Müdür";
            p1.Tarih = DateTime.Parse(date);
            p1.Adres.AcikAdres = "Zambak Sokak Silivri hücre 4";
            p1.Sube = "Esenler Market";



            p2.MaasHesapla(5000);
            p2.Isim = "Yunus";
            p2.Soyisim = "Kim";
            p2.Tc = 20;
            p2.Telefon = 05312541057;
            p2.Departman = "Müdür";
            p2.Tarih = DateTime.Parse(date);
            p2.Adres.AcikAdres = "Zambak Sokak Silivri hücre 3";
            p2.Sube = "Bagcılar Market";


            p3.MaasHesapla(4000);
            p3.Isim = "Kemal";
            p3.Soyisim = "Uygar";
            p3.Tc = 4;
            p3.Telefon = 05312551076;
            p3.Departman = "Müdür Yardımcısı";
            p3.Tarih = DateTime.Parse(date);
            p3.Adres.AcikAdres = "Zambak Sokak Silivri hücre 5";
            p3.Sube = "Esenler Market";


            p4.MaasHesapla(2324);
            p4.Isim = "Pelin";
            p4.Soyisim = "tok";
            p4.Tc = 5;
            p4.Telefon = 05312511056;
            p4.Departman = "Müdür Yardımcısı";
            p4.Tarih = DateTime.Parse(date);
            p4.Adres.AcikAdres = "Zambak Sokak Silivri hücre 6";
            p4.Sube = "Bagcılar Market";


            p5.MaasHesapla(2324);
            p5.Isim = "Ferit";
            p5.Soyisim = "karakaya";
            p5.Tc = 6;
            p5.Telefon = 05318551855;
            p5.Departman = "Kasiyer";
            p5.Tarih = DateTime.Parse(date);
            p5.Adres.AcikAdres = "Zambak Sokak Silivri hücre 7";
            p5.Sube = "Esenler Market";

            p6.MaasHesapla(2324);
            p6.Isim = "Ömer";
            p6.Soyisim = "Fesker";
            p6.Tc = 7;
            p6.Telefon = 05312951055;
            p6.Departman = "Kasiyer";
            p6.Tarih = DateTime.Parse(date);
            p6.Adres.AcikAdres = "Zambak Sokak Silivri hücre 8";
            p6.Sube = "Bagcılar Market";



            Personels.Add(p1);
            Personels.Add(p2);
            Personels.Add(p3);
            Personels.Add(p4);
            Personels.Add(p5);
            Personels.Add(p6);
            Personels.Add(yonetici);
            Personels.Add(yonetici2);
            
           
        }
        private void UrunOlustur()
        {
            string date = "22/07/2020";
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();
            Urun urun4 = new Urun();
            Urun urun5 = new Urun();
            Urun urun6 = new Urun();
            Urun urun7 = new Urun();
            Urun urun8 = new Urun();
            Urun urun9 = new Urun();
           

            urun1.barkodNo = 001;
            urun1.urunIsmi = "Patlayan Şeker";
            urun1.Fiyat = 1;
            urun1.stokSayisi = 90;
            urun1.alan = "gıda";
            urun1.marketadi = "bagcılar market";
            urun1.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun1);

            urun2.barkodNo = 002;
            urun2.urunIsmi = "Kalgon 1kg";
            urun2.Fiyat = 10;
            urun2.stokSayisi = 100;
            urun2.alan = "temizlik";
            urun2.marketadi = "esenler market";
            urun2.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun2);

            urun3.barkodNo = 003;
            urun3.urunIsmi = "Laptop";
            urun3.Fiyat = 6001;
            urun3.stokSayisi = 120;
            urun3.alan = "indirim";
            urun3.marketadi = "esenler market";
            urun3.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun3);

            urun4.barkodNo = 004;
            urun4.urunIsmi = "Çikolatalı gofret";
            urun4.Fiyat = 2;
            urun4.stokSayisi = 50;
            urun4.alan = "indirim";
            urun4.marketadi = "bagcılar market";
            urun4.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun4);

            urun5.barkodNo = 005;
            urun5.urunIsmi = "avize";
            urun5.Fiyat = 121;
            urun5.stokSayisi = 33;
            urun5.alan = "indirim";
            urun5.marketadi = "esenler market";
            urun5.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun5);

            urun6.barkodNo = 006;
            urun6.urunIsmi = "Dana Et 1Kg";
            urun6.Fiyat = 333;
            urun6.stokSayisi = 10;
            urun6.alan = "gıda";
            urun6.marketadi = "esenler market";
            urun6.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun6);

            urun7.barkodNo = 007;
            urun7.urunIsmi = "Tavuk Et 1kg";
            urun7.Fiyat = 111;
            urun7.stokSayisi = 10;
            urun7.alan = "gıda";
            urun7.marketadi = "bagcılar market";
            urun7.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun7);

            urun8.barkodNo = 008;
            urun8.urunIsmi = "Sıvı Sabun";
            urun8.Fiyat = 21;
            urun8.stokSayisi = 10;
            urun8.alan = "temizlik";
            urun8.marketadi = "esenler market";
            urun8.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun8);

            urun9.barkodNo = 009;
            urun9.urunIsmi = "CamSil";
            urun9.Fiyat = 14;
            urun9.stokSayisi = 100;
            urun9.alan = "temizlik";
            urun9.marketadi = "bagcılar market";
            urun9.SonIndirim = DateTime.Parse(date);
            Urunler.Add(urun9);

        }
        private void TedarikciOlustur()
        {
            Tedarikci temizlik = new Tedarikci();
            Tedarikci gida = new Tedarikci();
            Tedarikci indirim = new Tedarikci();
            temizlik.alan = "temizlik";
            temizlik.Isim = "Hakkı";
            temizlik.Soyisim = "Çavuş";
            temizlik.TedarikciAdres.AcikAdres = "Güngören Maltepe Mahallesi ";
            gida.alan = "gıda";
            gida.Isim = "Hakkı";
            gida.Soyisim = "Orgeneral";
            gida.TedarikciAdres.AcikAdres = "Güngören kokuşmuş Mahallesi ";
            indirim.alan = "indirim";
            indirim.Isim = "Hakkı";
            indirim.Soyisim = "TümGeneral";
            indirim.TedarikciAdres.AcikAdres = "Güngören Kartepe Mahallesi ";
            Tedarikcis.Add(temizlik);
            Tedarikcis.Add(gida);
            Tedarikcis.Add(indirim);

        }


        
    }
}       
    

