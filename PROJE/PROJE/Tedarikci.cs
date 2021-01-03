using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    public class Tedarikci :Insan 
    {
        public string alan { get; set; }
        public Adres TedarikciAdres { get; set; }

        public Tedarikci()
        {
            this.TedarikciAdres = new Adres();
        }
    }
}
