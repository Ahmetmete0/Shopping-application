using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    public class Sepet
    {
        
        public string SepeteUrunEkle(Urun urun) //Sepete ürün ekle fonksiyonunu kurduk ve burda ürünün adını döndürmesi için gerekli atamaları yaptık.
        {          
            string urunadi;
            urunadi = urun.Ad;

            return urunadi;

        }


        public double KdvUygula(double hamfiyat, double secilenadet, double kdvorani) //KdvUygula fonksiyonunda alınan parametreler ile doğru sayi bulunarak KdvliFiyata ı döndürdük ve listbox a yazdırdık.
        {
            double KdvliFiyat;
            KdvliFiyat = hamfiyat * secilenadet * kdvorani;


            return KdvliFiyat;

        }


    }
}
