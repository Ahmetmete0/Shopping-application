using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
   
    public class Urun //Urun özelliklerini tanıttığımız class.
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int stokAdedi;
        public int hamFiyat;
        public int secilenAdet;      
    }
    
    public class Buzdolabi : Urun //Urun class'ından miras alarak oluşturduğumuz buzdolabi class'ı.
    {
        public int IcHacim;
        public string EnerjiSinifi;

        static Random random = new Random();

        public Buzdolabi(string ad, string marka, string model, string ozellik, int hamfiyat, int ichacim, string enerjisinifi,int secilenadet) //Parametreli kurucu fonksiyonla atamalar yapıyoruz.
        {

            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            hamFiyat = hamfiyat;
            IcHacim = ichacim;
            EnerjiSinifi = enerjisinifi;
            secilenAdet = secilenadet;
            stokAdedi = random.Next(1, 100);
            System.Threading.Thread.Sleep(15);
        }

    }

    public class LedTV : Urun //Urun class'ından miras alarak oluşturduğumuz LedTV class'ı.
    {
        public int EkranBoyutu;
        public string EkranCozunurlugu;

        static Random random = new Random();

        public LedTV(string ad, string marka, string model, string ozellik, int hamfiyat, int ekranboyutu, string ekrancozunurlugu, int secilenadet) //Parametreli kurucu fonksiyonla atamalar yapıyoruz.
        {
            System.Threading.Thread.Sleep(10);
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            hamFiyat = hamfiyat;
            EkranBoyutu = ekranboyutu;
            EkranCozunurlugu = ekrancozunurlugu;
            secilenAdet = secilenadet;
            stokAdedi = random.Next(1, 100);

        }


    }


    public class CepTel : Urun //Urun class'ından miras alarak oluşturduğumuz ceptel class'ı.
    { 

        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        static Random random = new Random();
        public CepTel(string ad, string marka, string model, string ozellik, int hamfiyat, int dahilihafiza, int ramkapasitesi,int pilgucu, int secilenadet) //Parametreli kurucu fonksiyonla atamalar yapıyoruz.
        {
            System.Threading.Thread.Sleep(15);
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            hamFiyat = hamfiyat;
            DahiliHafiza = dahilihafiza;
            RamKapasitesi = ramkapasitesi;
            PilGucu = pilgucu;
            secilenAdet = secilenadet;
            stokAdedi = random.Next(1, 100);
            
        }


    }

    public class Laptop : Urun //Urun class'ından miras alarak oluşturduğumuz laptop class'ı.
    {

        public int EkranBoyutu;
        public string EkranCozunurluk;
        public int DahiliHafiza;
        public int RamKapasitesi;
        public int PilGucu;

        static Random random = new Random();

        public Laptop(string ad, string marka, string model, string ozellik, int hamfiyat, int dahilihafiza, int ramkapasitesi, int pilgucu,int ekranboyutu,string ekrancozunurlugu, int secilenadet) //Parametreli kurucu fonksiyonla atamalar yapıyoruz.
        {
            System.Threading.Thread.Sleep(20);
            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            hamFiyat = hamfiyat;
            DahiliHafiza = dahilihafiza;
            RamKapasitesi = ramkapasitesi;
            PilGucu = pilgucu;
            EkranBoyutu = ekranboyutu;
            EkranCozunurluk = ekrancozunurlugu;
            secilenAdet = secilenadet;
            stokAdedi = random.Next(1, 100);
            System.Threading.Thread.Sleep(15);


        }


    }

}
