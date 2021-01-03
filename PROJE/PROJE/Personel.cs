using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public class Personel : Insan
    {
        public long Tc { get; set; }
        public Adres Adres { get; set; }
        public long Telefon { get; set; }
        public DateTime Tarih { get; set; }
        public string Departman { get; set; }
        public string Sube { get; set; }
        protected int haftalikizin = 1;
        protected int senelikizin = 14;
        protected decimal maas = 0;
        
        public int HaftalikIzin
        {
            get
            {
                return haftalikizin;
            }
        }
        public int SenelikIzin
        {
            get
            {
                return senelikizin;
            }
        }
        public decimal Maas
        {
            get
            {
                return maas;
            }
        }
        public Personel()
        {
          
            this.Adres = new Adres();

         
        }
       
      

      
        public virtual void MaasHesapla(decimal yenimaas)
        {
            maas = yenimaas;
        }
        public virtual void SenelikIzinHesapla(int izin)
        {
            senelikizin = izin;
        }
        public virtual void HaftalikIzinHesapla(int izin)
        {
            haftalikizin = izin;
        }


    } 
  

}
