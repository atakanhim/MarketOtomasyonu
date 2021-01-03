using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public class Urun 
    {
        public long barkodNo { get; set; }
        public string urunIsmi { get; set; }
        public float Fiyat { get; set; }
        public int stokSayisi { get; set; }
        public  string marketadi { get; set; }
        public string alan { get; set; }
        public DateTime SonIndirim { get; set; }
        


        public string FiyatYazdir()
        {
            return  Fiyat.ToString() + " TL";
        }
        public Urun()
        {

        }
    }
}
