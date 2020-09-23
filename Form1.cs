/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Ekhtiram Khudiev
**				ÖĞRENCİ NUMARASI.......: B161210558
**              DERSİN ALINDIĞI GRUP...: 1A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B161210558
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Urun sınıfı
        public class Urun
        {

            public string Ad, Marka, Model, Ozellik;
            public int StokAdedi;
            public int HamFiyat, SecilenAdet;

            public Random RastgeleSayi = new Random();

            //Rastgele sayı tanım için. Urun Kurucu Fonksiyon
            public Urun()
            {
                Thread.Sleep(330);
                StokAdedi = RastgeleSayi.Next(1, 100);
            }
        }

        //LedTv sınıfı
        public class LedTv : Urun
        {
            string EkranBoyutu, EkranCozunurlugu;

            //Parametirli kurucu fonksiyon
            public LedTv(string Ad, string Marka, string Model, string Ozellik, int HamFiyat, int SecilenAdet, String EkranBoyutu, string EkranCozunurlugu)
            {
                this.Ad = Ad;
                this.Marka = Marka;
                this.Model = Model;
                this.Ozellik = Ozellik;
                this.HamFiyat = HamFiyat;
                this.SecilenAdet = SecilenAdet;
                this.EkranBoyutu = EkranBoyutu;
                this.EkranCozunurlugu = EkranCozunurlugu;
            }

            //KdvUygula fonksiyon
            public int KdvUygula()
            {
                return (HamFiyat * 118 * SecilenAdet) / 100;
            }
        }

        public class Buzdolabi : Urun
        {
            string IcHacim, EnerjiSinifi;


            //Parametirli kurucu fonksiyon
            public Buzdolabi(string Ad, string Marka, string Model, string Ozellik, int HamFiyat, int SecilenAdet, string IcHacim, string EnerjiSinifi)
            {
                this.Ad = Ad;
                this.Marka = Marka;
                this.Model = Model;
                this.Ozellik = Ozellik;
                this.HamFiyat = HamFiyat;
                this.SecilenAdet = SecilenAdet;
                this.IcHacim = IcHacim;
                this.EnerjiSinifi = EnerjiSinifi;
            }

            //KdvUygula fonksiyon
            public int KdvUygula()
            {
                return (HamFiyat * 118 * SecilenAdet) / 100;
            }
        }

        public class Laptop : Urun
        {
            string EkranBoyutu, EkranCozunurluk, DahiliHafiza, RamKapasitesi, Pilgucu;


            //Parametirli kurucu fonksiyon
            public Laptop(string Ad, string Marka, string Model, string Ozellik, int HamFiyat, int SecilenAdet, string EkranBoyutu, string EkranCozunurluk, string DahiliHafiza, string RamKapasitesi, string Pilgucu)
            {
                this.Ad = Ad;
                this.Marka = Marka;
                this.Model = Model;
                this.Ozellik = Ozellik;
                this.HamFiyat = HamFiyat;
                this.SecilenAdet = SecilenAdet;
                this.EkranBoyutu = EkranBoyutu;
                this.EkranCozunurluk = EkranCozunurluk;
                this.DahiliHafiza = DahiliHafiza;
                this.RamKapasitesi = RamKapasitesi;
                this.Pilgucu = Pilgucu;


            }

            //KdvUygula fonksiyon
            public int KdvUygula()
            {
                return (HamFiyat * 118 * SecilenAdet) / 100;
            }
        }

        class CepTel : Urun
        {
            string DahiliHafiza, RamKapasitesi, PilGucu;


            //Parametirli kurucu fonksiyon
            public CepTel(string Ad, string Marka, string Model, string Ozellik, int HamFiyat, int SecilenAdet, string DahiliHafiza, string RamKapasitesi, string PilGucu)
            {
                this.Ad = Ad;
                this.Marka = Marka;
                this.Model = Model;
                this.Ozellik = Ozellik;
                this.HamFiyat = HamFiyat;
                this.SecilenAdet = SecilenAdet;
                this.DahiliHafiza = DahiliHafiza;
                this.RamKapasitesi = RamKapasitesi;
                this.PilGucu = PilGucu;
            }

            //KdvUygula fonksiyon
            public int KdvUygula()
            {
                return (HamFiyat * 118 * SecilenAdet) / 100;
            }
        }

        //Sepet sınıfı
        public class Sepet
        {
            //Tanımlar
            public int LedTvStokAdedi, BuzdolabiStokAdedi, LaptopStokAdedi, CepTelStokAdedi;
            public int LedTvSecilenAdet, BuzdolabiSeccilenAdet, LaptopSecilenAdet, CepTelSecilenAdet;
            public int KdvToplamFiyat;
            public string LedTvUrun, BuzdolabiUrun, LaptopUrun, CepTelUrun;
            public int LedTvKdvFiyat, BuzdolabiKdvFiyat, LaptopKdvFiyat, CepTelKdvFiyat;

            //SepeteUrunEkle fonksiyonu  
            public void SepeteUrunEkle()
            {
                //Parametirli kurucu fonksiyonlara değer atanıyor
                LedTv LedTv = new LedTv("LedTv", "marka", "model", "ozellik", 4000, LedTvSecilenAdet, "wkranboyutu", "ekrancoz");
                Buzdolabi Buzdolabi = new Buzdolabi("Buzdolabi", "marka", "model", "ozellik", 3500, BuzdolabiSeccilenAdet, "wkranboyutu", "ekrancoz");
                Laptop Laptop = new Laptop("Laptop", "marka", "model", "ozellik", 6000, LaptopSecilenAdet, "ekranboyutu", "ekrancozunurluk", "dahilihafiza", "ramkapasitesi", "pilgucu");
                CepTel CepTel = new CepTel("CepTel", "marka", "model", "ozellik", 2500, CepTelSecilenAdet, "dahiliHafiza", "RamKapasitesi", "Pilguzu");

                //stok degerlerine atamalar yapılıyor
                LedTvStokAdedi -= LedTvSecilenAdet;
                BuzdolabiStokAdedi -= BuzdolabiSeccilenAdet;
                LaptopStokAdedi -= LaptopSecilenAdet;
                CepTelStokAdedi -= CepTelSecilenAdet;

                //Urun isimleri atanıyor
                LedTvUrun = LedTv.Ad;
                BuzdolabiUrun = Buzdolabi.Ad;
                LaptopUrun = Laptop.Ad;
                CepTelUrun = CepTel.Ad;

                //Kdv değerleri atanıyor 
                LedTvKdvFiyat = LedTv.KdvUygula();
                BuzdolabiKdvFiyat = Buzdolabi.KdvUygula();
                LaptopKdvFiyat = Laptop.KdvUygula();
                CepTelKdvFiyat = CepTel.KdvUygula();

                //toplam Kdv fıyatlar hesaplanıyor
                KdvToplamFiyat = LedTv.KdvUygula() + Buzdolabi.KdvUygula() + Laptop.KdvUygula() + CepTel.KdvUygula();
            }
        }

        //Program açıldığında
        private void Form1_Load(object sender, EventArgs e)
        {
            //Program Stok Adedlerine erişmesi için parametirli kurucu fonksiyonlar cağrılıyor 
            LedTv LedTv = new LedTv("LedTv", "marka", "model", "ozellik", 4000, Convert.ToInt32(numericUpDown1.Value), "wkranboyutu", "ekrancoz");
            Buzdolabi Buzdolabi = new Buzdolabi("Buzdolabi", "marka", "model", "ozellik", 3500, Convert.ToInt32(numericUpDown2.Value), "wkranboyutu", "ekrancoz");
            Laptop Laptop = new Laptop("Laptop", "marka", "model", "ozellik", 6000, Convert.ToInt32(numericUpDown3.Value), "ekranboyutu", "ekrancozunurluk", "dahilihafiza", "ramkapasitesi", "pilgucu");
            CepTel CepTel = new CepTel("CepTel", "marka", "model", "ozellik", 2500, Convert.ToInt32(numericUpDown4.Value), "dahiliHafiza", "RamKapasitesi", "Pilguzu");

            //StokAded'leri label ekleniyor 
            label5.Text = LedTv.StokAdedi.ToString();
            label6.Text = Buzdolabi.StokAdedi.ToString();
            label11.Text = Laptop.StokAdedi.ToString();
            label16.Text = CepTel.StokAdedi.ToString();
        }

        public int GirisBileti = 0;
        public int LedTvStokAdedi, BuzdolabiStokAdedi, LaptopStokAdedi, CepTelStokAdedi;

        //SepetUrunEkle Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //GirisBileti sıfıra eşit olmasa bu fonksiyon çalışmıyor
            //ilk girildiğinde ve SepetiTemizle butonuna tıklandığında  çalışıyor
            if (GirisBileti == 0)
            {
                Sepet Sepet = new Sepet();

                //Label'lere eklenen ilk değerler yeniden StokAdedlerine ekleniyor
                Sepet.LedTvStokAdedi = int.Parse(label5.Text);
                Sepet.BuzdolabiStokAdedi = int.Parse(label6.Text);
                Sepet.LaptopStokAdedi = int.Parse(label11.Text);
                Sepet.CepTelStokAdedi = int.Parse(label16.Text);

                //numericUpDown'da seçilen rakamlar SecilenAdet'lere ekleniyor
                Sepet.LedTvSecilenAdet = Convert.ToInt32(numericUpDown1.Value);
                Sepet.BuzdolabiSeccilenAdet = Convert.ToInt32(numericUpDown2.Value);
                Sepet.LaptopSecilenAdet = Convert.ToInt32(numericUpDown3.Value);
                Sepet.CepTelSecilenAdet = Convert.ToInt32(numericUpDown4.Value);

                //SepeteUrunEkle sınıfı çağrılıyor
                Sepet.SepeteUrunEkle();

                //yeni stoklar text'lere ekleniyor
                label5.Text = Sepet.LedTvStokAdedi.ToString();
                label6.Text = Sepet.BuzdolabiStokAdedi.ToString();
                label11.Text = Sepet.LaptopStokAdedi.ToString();
                label16.Text = Sepet.CepTelStokAdedi.ToString();

                ////Seçilen Adetle  Stok Adedi toplanıyor   
                LedTvStokAdedi = Sepet.LedTvStokAdedi + Sepet.LedTvSecilenAdet;
                BuzdolabiStokAdedi = Sepet.BuzdolabiStokAdedi + Sepet.BuzdolabiSeccilenAdet;
                LaptopStokAdedi = Sepet.LaptopStokAdedi + Sepet.LaptopSecilenAdet;
                CepTelStokAdedi = Sepet.CepTelStokAdedi + Sepet.CepTelSecilenAdet;

                //Seçilen Adet sıfıra eşit değilse bilgiler listBox'lara ekleniyor 
                if (Sepet.LedTvSecilenAdet != 0)
                {
                    listBox1.Items.Add(Sepet.LedTvSecilenAdet);
                    listBox2.Items.Add(Sepet.LedTvUrun);
                    listBox3.Items.Add(Sepet.LedTvKdvFiyat);
                    GirisBileti++;
                }

                //Seçilen Adet sıfıra eşit değilse bilgiler listBox'lara ekleniyor 
                if (Sepet.BuzdolabiSeccilenAdet != 0)
                {
                    listBox1.Items.Add(Sepet.BuzdolabiSeccilenAdet);
                    listBox2.Items.Add(Sepet.BuzdolabiUrun);
                    listBox3.Items.Add(Sepet.BuzdolabiKdvFiyat);
                    GirisBileti++;
                }

                //Seçilen Adet sıfıra eşit değilse bilgiler listBox'lara ekleniyor 
                if (Sepet.LaptopSecilenAdet != 0)
                {
                    listBox1.Items.Add(Sepet.LaptopSecilenAdet);
                    listBox2.Items.Add(Sepet.LaptopUrun);
                    listBox3.Items.Add(Sepet.LaptopKdvFiyat);
                    GirisBileti++;
                }

                //Seçilen Adet sıfıra eşit değilse bilgiler listBox'lara ekleniyor 
                if (Sepet.CepTelSecilenAdet != 0)
                {
                    listBox1.Items.Add(Sepet.CepTelSecilenAdet);
                    listBox2.Items.Add(Sepet.CepTelUrun);
                    listBox3.Items.Add(Sepet.CepTelKdvFiyat);
                    GirisBileti++;
                }

                //Kdv'li toplam fiyat label ekleniyor
                label22.Text = Sepet.KdvToplamFiyat.ToString() + " TL";
            }

            //eğer GirişBileti sıfır olmasa ekran mesaj çıkıyor
            else
            {
                MessageBox.Show("Sepet Dolu Lutfen Sepeti temizleyin...", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Sepeti Temizle Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            //stokar yerine ekleniyor
            label5.Text = LedTvStokAdedi.ToString();
            label6.Text = BuzdolabiStokAdedi.ToString();
            label11.Text = LaptopStokAdedi.ToString();
            label16.Text = CepTelStokAdedi.ToString();

            //lıstBox'lar temizleniyor
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //Kdv li toplam fiyat sıfır eşitleniyor
            label22.Text = "0 TL";

            //GirişBileti sıfıra eşitleniyor
            GirisBileti = 0;
        }
    }
}
