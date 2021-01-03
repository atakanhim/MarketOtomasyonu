using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class Anaekran : Form
    {
        public String girendepartman = "";
        Market m1 = new Market();
        Market m2 = new Market();
        

        public Anaekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void Anaekran_Load(object sender, EventArgs e)
        {
            m1.MarketAdi = "Esenler Market";
            m1.MarketAdres.AcikAdres = "Esenlerde uçsuz bucaksız  bir yerde ";
            
            m2.MarketAdi = "Bagcılar Market";
            m2.MarketAdres.AcikAdres = "Bagcılarda uçsuz bucaksız bir yerde";
            Market tumurunler = new Market();

            m1.Urunler.Clear();
            m2.Urunler.Clear();
            m1.Personels.Clear();
            m2.Personels.Clear();
            if (true)
            {
                foreach (Urun u in tumurunler.Urunler)
                {        
                    if (u.marketadi.ToLower() == "esenler market")
                    {
                        m1.UrunEkle(u);
                    }
                    if (u.marketadi.ToLower() == "bagcılar market")
                    {
                        m2.UrunEkle(u);
                    }
                }
                foreach (Personel u in tumurunler.Personels)
                {

                    if (u.Sube.ToLower() == "esenler market")
                    {
                        m1.PersonelEkle(u);
                    }
                    if (u.Sube.ToLower() == "bagcılar market")
                    {
                        m2.PersonelEkle(u);
                    }

                }

            }
               
            
           
           

            cikis_btn.Enabled = false;
            yonetim_tabcont.Enabled = false;
            urun_tabcontrol.Enabled = false;
            urunupdate_control.Enabled = false;

            
        }
        // FonkSiyonlarr

        private void TedarikciListele()// Tedarikçi Ve Marketlerimi
        {
            int personelsayisi;
            int urunsayisi;
            tedarikci_liste.Items.Clear();
            marketliste_wiew.Items.Clear();
            foreach (Tedarikci x in m1.Tedarikcis)
            {

                string[] row = { x.Isim, x.Soyisim, x.alan, x.TedarikciAdres.AcikAdres };
                var ekle = new ListViewItem(row);
                tedarikci_liste.Items.Add(ekle);


            }

            // market 1 için Marketdeki personel vve urunlerin sayisini yazdırma
            if (true)
            {
                personelsayisi = 0; urunsayisi = 0;
                foreach (Personel x in m1.Personels)
                    personelsayisi++;
                foreach (Urun u in m1.Urunler)
                    urunsayisi++;
                string[] row = { m1.MarketAdi, personelsayisi.ToString(), urunsayisi.ToString(), m1.MarketAdres.AcikAdres };
                var ekle = new ListViewItem(row);
                marketliste_wiew.Items.Add(ekle);
            }

            // market 2  için
            if (true)
            {
                personelsayisi = 0; urunsayisi = 0;
                foreach (Personel x in m2.Personels)
                    personelsayisi++;
                foreach (Urun u in m2.Urunler)
                    urunsayisi++;
                string[] row = { m2.MarketAdi, personelsayisi.ToString(), urunsayisi.ToString(), m2.MarketAdres.AcikAdres };
                var ekle = new ListViewItem(row);
                marketliste_wiew.Items.Add(ekle);
            }
        }
        private void EsenlerListele()
        {
            esenler_liste.Items.Clear();
            foreach (Personel x in m1.Personels)
            {
                string[] row = { x.Isim, x.Soyisim, x.Departman, x.Sube };
                var ekle = new ListViewItem(row);
                esenler_liste.Items.Add(ekle);
            }
            esenlerurunler.Items.Clear();
            foreach (Urun u in m1.Urunler)
            {
                string[] row = { u.barkodNo.ToString(), u.urunIsmi, u.stokSayisi.ToString(), u.FiyatYazdir(), u.alan, u.marketadi, u.SonIndirim.ToString() };
                var ekle = new ListViewItem(row);
                esenlerurunler.Items.Add(ekle);
            }

        }
                private void BagcilarListele()
        {
            bagcilarliste.Items.Clear();
            foreach (Personel x in m2.Personels)
            {
                string[] row = { x.Isim, x.Soyisim, x.Departman, x.Sube };
                var ekle = new ListViewItem(row);
                bagcilarliste.Items.Add(ekle);
            }
            bagcilarurunler.Items.Clear();
            foreach (Urun u in m2.Urunler)
            {
                string[] row = { u.barkodNo.ToString(), u.urunIsmi, u.stokSayisi.ToString(), u.FiyatYazdir(), u.alan, u.marketadi, u.SonIndirim.ToString() };
                var ekle = new ListViewItem(row);
                bagcilarurunler.Items.Add(ekle);
            }


        }
        private void Listele()
        {
            TedarikciListele();
            BagcilarListele();
            EsenlerListele();
            listView1.Items.Clear();
            tumurunler_liste.Items.Clear();

            foreach (Personel x in m1.Personels)
            {
                string[] row = { x.Isim, x.Soyisim, x.Telefon.ToString(), x.Tarih.ToString(), x.Departman, x.Adres.AcikAdres, x.Maas.ToString(), x.Tc.ToString(), x.SenelikIzin.ToString(), x.HaftalikIzin.ToString(), x.Sube };
                var ekle = new ListViewItem(row);
                listView1.Items.Add(ekle);
            }
            foreach (Personel x in m2.Personels)
            {
                string[] row = { x.Isim, x.Soyisim, x.Telefon.ToString(), x.Tarih.ToString(), x.Departman, x.Adres.AcikAdres, x.Maas.ToString(), x.Tc.ToString(), x.SenelikIzin.ToString(), x.HaftalikIzin.ToString(), x.Sube };
                var ekle = new ListViewItem(row);
                listView1.Items.Add(ekle);
            }


            foreach (Urun u in m1.Urunler)
            {

                string[] row = { u.barkodNo.ToString(), u.urunIsmi, u.stokSayisi.ToString(), u.FiyatYazdir(), u.alan, u.marketadi, u.SonIndirim.ToString() };
                var ekle = new ListViewItem(row);
                tumurunler_liste.Items.Add(ekle);

            }
            foreach (Urun u in m2.Urunler)
            {

                string[] row = { u.barkodNo.ToString(), u.urunIsmi, u.stokSayisi.ToString(), u.FiyatYazdir(), u.alan, u.marketadi, u.SonIndirim.ToString() };
                var ekle = new ListViewItem(row);
                tumurunler_liste.Items.Add(ekle);

            }

        }
  
        private void Alantemizle()
        {
            ad_txt.Text = "";
            soyad_txt.Text = "";
            tc_txt.Text = "";
            makam_combo.Text = "";
            adres_txt.Text = "";
            telefon_txt.Text = ""; 
            maas_txt.Text = "";
            sube_combo.Text = "";
        }
        private void Ekle()
        {
            Personel pi = new Personel();

            pi.Isim = ad_txt.Text;
            pi.Soyisim = soyad_txt.Text;
            pi.Tc = Convert.ToInt64(tc_txt.Text);
            pi.Tarih = tarih_pickers.Value;
            pi.Departman = makam_combo.Text;
            pi.Adres.AcikAdres = adres_txt.Text;
            pi.Telefon = Convert.ToInt64(telefon_txt.Text);
            pi.MaasHesapla(Convert.ToInt32(maas_txt.Text));
            pi.Sube = sube_combo.Text;
            if (pi.Sube.ToLower() == "esenler market")
                m1.PersonelEkle(pi);
            if (pi.Sube.ToLower() == "bagcılar market")
                m2.PersonelEkle(pi);


        }

        // Butonlar
        private void persoekle_btn_Click(object sender, EventArgs e)
        {
            bool deger = true;
            foreach (Personel perso in m1.Personels)
            {
                if (tc_txt.Text == perso.Tc.ToString())
                    deger = false;
            }
            foreach (Personel perso in m2.Personels)
            {
                if (tc_txt.Text == perso.Tc.ToString())
                    deger = false;
            }
            if (deger == false)
            {
                MessageBox.Show("Bu Tc Numarası zaten kayıtlı");
            }
            else if (adres_txt.Text == "")
            {
                MessageBox.Show("Adres Alan Boş Bırakılamaz İşleminiz İptal Edildi");
                Alantemizle();
            }

            else if (tc_txt.Text == "" || telefon_txt.Text == "" || telefon_txt.Text == "" || maas_txt.Text == "" || makam_combo.Text == "")
            {
                MessageBox.Show("Tüm alanları Doldurun");
            }


            else if (!(makam_combo.Text.ToLower() == "müdür" || makam_combo.Text.ToLower() == "müdür yardımcısı" || makam_combo.Text.ToLower() == "kasiyer"))
            {
                MessageBox.Show("Geçersiz Personel Makamı");
            }
            else if (!(sube_combo.Text.ToLower() == "esenler market" || sube_combo.Text.ToLower() == "bagcılar market"))
            {
                MessageBox.Show("Geçersiz Şube");
            }


            else
            {

                Ekle();
                Alantemizle();
            }
            Listele();
        }// Personel İzin

        private void button2_Click(object sender, EventArgs e)
        {
            int deger = 0;

            if (true)// m1 personeli için kontrol ediyor 
            {
                foreach (Personel x in m1.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (x.SenelikIzin == 0)
                            MessageBox.Show("Senelik İzin Zaten Kalmamış");
                        else if (yillikizin_txt.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Deger Giriniz");

                        }
                        else if (Convert.ToInt32(yillikizin_txt.Text) > x.SenelikIzin)
                        {
                            MessageBox.Show("Bu personelin bu kadar izin hakkı yok");
                        }
                        else if (Convert.ToInt32(yillikizin_txt.Text) <= x.SenelikIzin)
                        {
                            int sonuc = x.SenelikIzin - Convert.ToInt32(yillikizin_txt.Text);
                            x.SenelikIzinHesapla(sonuc);
                            MessageBox.Show("İşlem tamam");
                        }
                        deger = 1;
                    }
                }
            }
            if (deger == 0) // m2. personelleri için kontrol ediyor
            {
                foreach(Personel x in m2.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (x.SenelikIzin == 0)
                            MessageBox.Show("Senelik İzin Zaten Kalmamış");
                        else if (yillikizin_txt.Text == "")
                        {
                            MessageBox.Show("Lütfen Bir Deger Giriniz");

                        }
                        else if (Convert.ToInt32(yillikizin_txt.Text) > x.SenelikIzin)
                        {
                            MessageBox.Show("Bu personelin bu kadar izin hakkı yok");
                        }
                        else if (Convert.ToInt32(yillikizin_txt.Text) <= x.SenelikIzin)
                        {
                            int sonuc = x.SenelikIzin - Convert.ToInt32(yillikizin_txt.Text);
                            x.SenelikIzinHesapla(sonuc);
                            MessageBox.Show("İşlem tamam");
                        }
                        deger = 1;
                    }
                }
            }
           



            if (personeltc_txt.Text == "")
                MessageBox.Show("Lütfen Önce Güncellemek istediginiz Personelin TC Numarası Giriniz");
            else if (deger == 0)
                MessageBox.Show("Girdiginiz TC Sistemde kayıtlı degil");
            Listele();
        }// Senelik izin

        private void button3_Click(object sender, EventArgs e)
        {
            int deger = 0;
            if (true) // Market 1 için kontrol ediliyor
            {
                foreach (Personel x in m1.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (x.HaftalikIzin == 0)
                            MessageBox.Show("Haftalık İzin Zaten Kalmamış");
                        else
                        {
                            x.HaftalikIzinHesapla(0);
                            MessageBox.Show("Haftalık İzin Harcandı");
                        }
                        deger = 1;
                    }
                }
            }
            if (deger == 0) // Bulamadıysa Market 2 için
            {
                foreach (Personel x in m2.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (x.HaftalikIzin == 0)
                            MessageBox.Show("Haftalık İzin Zaten Kalmamış");
                        else
                        {
                            x.HaftalikIzinHesapla(0);
                            MessageBox.Show("Haftalık İzin Harcandı");
                        }
                        deger = 1;
                    }
                }
            }
            if (personeltc_txt.Text == "")
                MessageBox.Show("Lütfen Önce Güncellemek istediginiz Personelin TC Numarası Giriniz");
            else if (deger == 0)
                MessageBox.Show("Girdiginiz TC Sistemde kayıtlı degil");
            Listele();
        }// Haftalık İzin

        private void maas_artir_Click(object sender, EventArgs e)
        {
            int deger = 0;
            if (true) // market 1 içinde varmı 
            {
                foreach (Personel x in m1.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (yenimaas_txt.Text == "")
                        {
                            MessageBox.Show("Maaş alanı Boş geçilemez");
                        }
                        else if (Convert.ToInt32(yenimaas_txt.Text) > x.Maas)
                        {
                            x.MaasHesapla(Convert.ToInt32(yenimaas_txt.Text));

                            MessageBox.Show("işlem tamam");


                        }
                        else
                        {
                            MessageBox.Show("Eskisinden daha az bir miktar giremezsiniz");
                        }
                        deger = 1;
                    }
                }
            }
            if (deger ==0)// yoksa burda varmı o tc
            {
                foreach (Personel x in m2.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (yenimaas_txt.Text == "")
                        {
                            MessageBox.Show("Maaş alanı Boş geçilemez");
                        }
                        else if (Convert.ToInt32(yenimaas_txt.Text) > x.Maas)
                        {
                            x.MaasHesapla(Convert.ToInt32(yenimaas_txt.Text));

                            MessageBox.Show("işlem tamam");


                        }
                        else
                        {
                            MessageBox.Show("Eskisinden daha az bir miktar giremezsiniz");
                        }
                        deger = 1;
                    }
                }
            }
            
            if (personeltc_txt.Text == "")
                MessageBox.Show("Lütfen Önce Güncellemek istediginiz Personelin TC Numarası Giriniz");
            else if (deger == 0)
                MessageBox.Show("Girdiginiz TC Sistemde kayıtlı degil");
            yenimaas_txt.Text = "";
            Listele();

        }// Maaş Arttırma

        private void terfi_btn_Click(object sender, EventArgs e)
        {
            int deger = 0;
            if (true)
            {
                foreach (Personel x in m1.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (terfi_combo.Text == "")
                        {
                            MessageBox.Show("Boş Makam adı");


                        }
                        else if (!(terfi_combo.Text.ToLower() == "müdür" || terfi_combo.Text.ToLower() == "müdür yardımcısı" || terfi_combo.Text.ToLower() == "kasiyer"))
                        {
                            MessageBox.Show("Geçersiz Personel Makamı");
                        }
                        else if ((terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "müdür yardımcısı") || (terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "kasiyer") || (terfi_combo.Text.ToLower() == "müdür yardımcısı" && x.Departman.ToLower() == "kasiyer"))
                        {
                            x.Departman = terfi_combo.Text;

                            MessageBox.Show("işlem tamam");
                            terfi_combo.Text = "";

                        }
                        else if ((terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "müdür") || (terfi_combo.Text.ToLower() == "müdür yardımcısı" && x.Departman.ToLower() == "müdür yardımcısı"))
                        {
                            MessageBox.Show("Terfi ettirmek istediginiz kademe ile personolin şuanki kademesi aynı");
                        }
                        else
                        {
                            MessageBox.Show("Terfi ettirmek istediginiz kademe şuankinden daha düşük oldugu için işlem GEÇERSİZ DİR");
                        }
                        deger = 1;
                    }

                }
            }
            if (deger ==0)
            {
                foreach (Personel x in m2.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (terfi_combo.Text == "")
                        {
                            MessageBox.Show("Boş Makam adı");


                        }
                        else if (!(terfi_combo.Text.ToLower() == "müdür" || terfi_combo.Text.ToLower() == "müdür yardımcısı" || terfi_combo.Text.ToLower() == "kasiyer"))
                        {
                            MessageBox.Show("Geçersiz Personel Makamı");
                        }
                        else if ((terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "müdür yardımcısı") || (terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "kasiyer") || (terfi_combo.Text.ToLower() == "müdür yardımcısı" && x.Departman.ToLower() == "kasiyer"))
                        {
                            x.Departman = terfi_combo.Text;

                            MessageBox.Show("işlem tamam");
                            terfi_combo.Text = "";

                        }
                        else if ((terfi_combo.Text.ToLower() == "müdür" && x.Departman.ToLower() == "müdür") || (terfi_combo.Text.ToLower() == "müdür yardımcısı" && x.Departman.ToLower() == "müdür yardımcısı"))
                        {
                            MessageBox.Show("Terfi ettirmek istediginiz kademe ile personolin şuanki kademesi aynı");
                        }
                        else
                        {
                            MessageBox.Show("Terfi ettirmek istediginiz kademe şuankinden daha düşük oldugu için işlem GEÇERSİZ DİR");
                        }
                        deger = 1;
                    }

                }
            }
           
            if (personeltc_txt.Text == "")
                MessageBox.Show("Lütfen Önce Güncellemek istediginiz Personelin TC Numarası Giriniz");
            else if (deger == 0)
                MessageBox.Show("Girdiginiz TC Sistemde kayıtlı degil");
            terfi_combo.Text = "";

            Listele();
        }//Terfi Ettirme

        private void subeupdate_btn_Click(object sender, EventArgs e)
        {
            int deger = 0;
            int updateDeger = 0;
            Personel update = new Personel();
            if (true)
            {
                foreach (Personel x in m1.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (subeupdate_combo.Text == "")
                        {
                            MessageBox.Show("Boş Makam adı");


                        }
                        else if (!(subeupdate_combo.Text.ToLower() == "esenler market" || subeupdate_combo.Text.ToLower() == "bagcılar market"))
                        {
                            MessageBox.Show("Geçersiz Şube");
                        }
                        else if (subeupdate_combo.Text.ToLower() == "esenler market" && x.Sube.ToLower() == "esenler market")
                        {

                            MessageBox.Show("Zaten Atamak İstediginiz şubede görev yapıyor");
                            subeupdate_combo.Text = "";

                        }

                        else
                        {
                           
                            x.Sube = subeupdate_combo.Text;
                            update = x;
                            m2.PersonelEkle(update);
                            updateDeger = 1;
                        }
                        deger = 1;
                    }

                }
            }
            if (deger==0)
            {
                foreach (Personel x in m2.Personels)
                {
                    if (personeltc_txt.Text == x.Tc.ToString())
                    {
                        if (subeupdate_combo.Text == "")
                        {
                            MessageBox.Show("Boş Makam adı");


                        }
                        else if (!(subeupdate_combo.Text.ToLower() == "esenler market" || subeupdate_combo.Text.ToLower() == "bagcılar market"))
                        {
                            MessageBox.Show("Geçersiz Şube");
                        }
                        else if ((subeupdate_combo.Text.ToLower() == "esenler market" && x.Sube.ToLower() == "esenler market") || (subeupdate_combo.Text.ToLower() == "bagcılar market" && x.Sube.ToLower() == "bagcılar market"))
                        {

                            MessageBox.Show("Zaten Atamak İstediginiz şubede görev yapıyor");
                            subeupdate_combo.Text = "";

                        }
                        
                        else
                        {
                            x.Sube = subeupdate_combo.Text;
                            update = x;
                            m1.PersonelEkle(update);
                            updateDeger = 2;
                        }
                        deger = 1;
                    }

                }
            }
            if (personeltc_txt.Text == "")
                MessageBox.Show("Lütfen Önce Güncellemek istediginiz Personelin TC Numarası Giriniz");
            else if (deger == 0)
                MessageBox.Show("Girdiginiz TC Sistemde kayıtlı degil");
            else if(updateDeger == 1)
            {
                m1.PersoSil(update);
                MessageBox.Show("Şube Degiştirildi");
            }
            else if (updateDeger == 2)
            {
                m2.PersoSil(update);
                MessageBox.Show("Şube Degiştirildi");
            }
            subeupdate_combo.Text = "";
            Listele();
 
        }//  Sube Degişikligi

        private void urunekle_btn_Click(object sender, EventArgs e)
        {
            if (barkod_txt.Text==""||urunismi_txt.Text==""||fiyat_txt.Text==""||stok_sayisi.Text==""||hangimarket_cmb.Text==""||uruntur_cmb.Text=="")
            {
                MessageBox.Show("Tüm alanları doldurun");
            }
            else if (!(hangimarket_cmb.Text =="bagcılar market"|| hangimarket_cmb.Text =="esenler market"))
            {
                MessageBox.Show("Market İsmi Hatalı Girdiniz");
                hangimarket_cmb.Text = "";
            }
            else if (!(uruntur_cmb.Text == "gıda"|| uruntur_cmb.Text == "temizlik"|| uruntur_cmb.Text == "indirim"))
            {
                MessageBox.Show("Urun Türünü yanlış girdiniz");
            }
            else
            {
                Urun EklenecekUrun = new Urun();
                bool x = true;
                foreach (Urun u in m1.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(barkod_txt.Text))
                    {
                        MessageBox.Show("Bu kodda ürün vardır");
                        x = false;
                    }
                }
                foreach (Urun u in m2.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(barkod_txt.Text))
                    {
                        MessageBox.Show("Bu kodda ürün vardır");
                        x = false;
                    }
                }
                if (x == true)
                {
                    EklenecekUrun.barkodNo = Convert.ToInt64(barkod_txt.Text);
                    EklenecekUrun.Fiyat = Convert.ToInt32(fiyat_txt.Text);
                    EklenecekUrun.stokSayisi = Convert.ToInt32(stok_sayisi.Text);
                    EklenecekUrun.alan = uruntur_cmb.Text;
                    EklenecekUrun.marketadi = hangimarket_cmb.Text;
                    EklenecekUrun.urunIsmi = urunismi_txt.Text;
                    EklenecekUrun.SonIndirim = dateTimePicker1.Value;
                    if (EklenecekUrun.marketadi.ToLower() == "esenler market")
                        m1.UrunEkle(EklenecekUrun);
                    if (EklenecekUrun.marketadi.ToLower() == "bagcılar market")
                        m2.UrunEkle(EklenecekUrun);
                    
                    MessageBox.Show("Ürün ekleme işlemi tamam");
                    Listele();
                }

            }
        }// urun ekleme
      
        private void stokarttir_btn_Click(object sender, EventArgs e)
        {
            if (updatebarkod_txt.Text==""||artirstok_txt.Text=="")
            {
                MessageBox.Show("Arttırılıcak miktara ve barkod numarasının dolu oldugundan emin olun");
            }
            else
            {
                Urun EklenecekUrun = new Urun();
                bool x = false;
                foreach (Urun u in m1.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(updatebarkod_txt.Text))
                    {
                        x = true;
                        EklenecekUrun.stokSayisi = Convert.ToInt32(artirstok_txt.Text);
                        EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                        m1.UrunEkle(EklenecekUrun);
                        MessageBox.Show("Ürün güncelleme işlemi tamam");
                       
                    }
                }
                foreach (Urun u in m2.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(updatebarkod_txt.Text))
                    {
                        x = true;
                        EklenecekUrun.stokSayisi = Convert.ToInt32(artirstok_txt.Text);
                        EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                        m2.UrunEkle(EklenecekUrun);
                        MessageBox.Show("Ürün güncelleme işlemi tamam");

                    }
                }

                if (x == false)
                    MessageBox.Show("Bur barkod no da urun yoktur");
           
               
            }
      

            Listele();
            
        }// stok arttırma

        private void indirimyap_btn_Click(object sender, EventArgs e)
        {
            float indirimmiktar=0;
            if (updatebarkod_txt.Text == "" || indirimmiktar_txt.Text == "")
            {
                MessageBox.Show("İndirim miktarının ve barkod numarasının dolu oldugundan emin olun");
            }
           
            else
            {
                Urun EklenecekUrun = new Urun();
                bool x = false;
                foreach (Urun u in m1.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(updatebarkod_txt.Text))
                    {
                        x = true;     
                        if(girendepartman=="müdür"&&u.alan=="indirim")
                        {
                            EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                            indirimmiktar = Convert.ToInt32(indirimmiktar_txt.Text);
                            m1.IndirimYap(EklenecekUrun, indirimmiktar);
                            MessageBox.Show("Ürün İndirim işlemi tamam");
                        }
                        else if (!(girendepartman == "müdür"))
                        {
                            EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                            indirimmiktar = Convert.ToInt32(indirimmiktar_txt.Text);
                            m1.IndirimYap(EklenecekUrun, indirimmiktar);
                            MessageBox.Show("Ürün İndirim işlemi tamam");
                        }
                        else
                        {
                            MessageBox.Show("Sadece indirim türündeki ürünlere indirim tanımlıyabilirsiniz ,Müdürsün sen müdür kal");
                        }
                        

                    }
                }
                foreach (Urun u in m2.Urunler)
                {
                    if (u.barkodNo == Convert.ToInt32(updatebarkod_txt.Text))
                    {
                        x = true;
                        if (girendepartman == "müdür" && u.alan == "indirim")
                        {
                            EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                            indirimmiktar = Convert.ToInt32(indirimmiktar_txt.Text);
                            m2.IndirimYap(EklenecekUrun, indirimmiktar);
                            MessageBox.Show("Ürün İndirim işlemi tamam");
                            indirimmiktar_txt.Text = "";
                        }
                        else if (!(girendepartman == "müdür"))
                        {
                            EklenecekUrun.barkodNo = Convert.ToInt32(updatebarkod_txt.Text);
                            indirimmiktar = Convert.ToInt32(indirimmiktar_txt.Text);
                            m2.IndirimYap(EklenecekUrun, indirimmiktar);
                            MessageBox.Show("Ürün İndirim işlemi tamam");
                            indirimmiktar_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Sadece indirim türündeki ürünlere indirim tanımlıyabilirsiniz ,Müdürsün sen müdür kal");
                        }


                    }
                }

                if (x == false)
                    MessageBox.Show("Bur barkod no da urun yoktur");

            }

            Listele();
        }// indirim yapma


        //Giriş Çıkış
        private void giris_btn_Click(object sender, EventArgs e)
        {
            
            bool x = false;
            foreach (Personel perso in m1.Personels)
            {
                if (giris_txt.Text == perso.Tc.ToString())
                {
                    x = true;
                    giris_txt.Text = "";
                    giris_txt.Enabled = false;
                    MessageBox.Show("Hoş Geldin " + perso.Isim + "\nUnvan : " + perso.Departman);
                    cikis_btn.Enabled = true;
                    giris_btn.Enabled = false;
                    giris1.Text = "Hoş Geldin , " + perso.Isim + "\nUnvan : " + perso.Departman;
                    giris2.Text = "Hoş Geldin " + perso.Isim + "\nUnvan : " + perso.Departman;
                    giren_label.Text = "Hoş Geldin ," + perso.Isim + " Unvan : " + perso.Departman + ",  Bu alanda İznin Yok";


                    urun_tabcontrol.Enabled = true;
                    if (perso.Departman.ToLower() == "yonetici")
                    {
                        giren_label.Text = "Hoş Geldin ," + perso.Isim + " Unvan : " + perso.Departman;
                        yonetim_tabcont.Enabled = true;
                        Listele();
                        TedarikciListele();

                        urunupdate_control.Enabled = true;
                    }
                    else if (perso.Departman.ToLower() == "müdür")
                    {
                        
                        girendepartman = "müdür";
                        urunupdate_control.Enabled = true;
                        
                    }

                    else
                    {
                        urunupdate_control.Enabled = false;
                        
                    }
                    EsenlerListele();
                    BagcilarListele();

                }
            }
            foreach (Personel perso in m2.Personels)
            {
                if (giris_txt.Text == perso.Tc.ToString())
                {
                    x = true;
                    giris_txt.Text = "";
                    giris_txt.Enabled = false;
                    MessageBox.Show("Hoş Geldin " + perso.Isim + "\nUnvan : " + perso.Departman);
                    cikis_btn.Enabled = true;
                    giris_btn.Enabled = false;
                    giris1.Text = "Hoş Geldin , " + perso.Isim + "\nUnvan : " + perso.Departman;
                    giris2.Text = "Hoş Geldin " + perso.Isim + "\nUnvan : " + perso.Departman;
                    giren_label.Text = "Hoş Geldin ," + perso.Isim + " Unvan : " + perso.Departman + ",  Bu alanda İznin Yok";


                    urun_tabcontrol.Enabled = true;
                    if (perso.Departman.ToLower() == "yonetici")
                    {
                        giren_label.Text = "Hoş Geldin ," + perso.Isim + " Unvan : " + perso.Departman;
                        yonetim_tabcont.Enabled = true;
                        Listele();
                        TedarikciListele();

                        urunupdate_control.Enabled = true;
                    }
                    else if (perso.Departman.ToLower() == "müdür")
                    {

                        girendepartman = "müdür";
                        urunupdate_control.Enabled = true;

                    }

                    else
                    {
                        urunupdate_control.Enabled = false;

                    }
                    EsenlerListele();
                    BagcilarListele();

                }
            }
            if (x == false)
            {
                giris_txt.Text = "";
                MessageBox.Show("Sistemde Kayıtlı Degilsin");
            }

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            giris1.Text = "Lütfen Giriş Yapın";
            giris2.Text = "Giriş Yapılmadı";
            giren_label.Text= "Giriş Yapılmadı";

            giris_txt.Enabled = true;
            cikis_btn.Enabled = false;
            yonetim_tabcont.Enabled = false;
            urun_tabcontrol.Enabled = false;
            urunupdate_control.Enabled = false;
            giris_btn.Enabled = true;
            listView1.Items.Clear();
            esenler_liste.Items.Clear();
            bagcilarliste.Items.Clear();
        }


       
    }
}
