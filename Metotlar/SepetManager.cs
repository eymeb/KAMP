using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {

          Console.WriteLine("Tebrikler. Sepete ekle! : " + urun.Adi);

        }

        public void Ekle2(string urunAdi,string Aciklama,double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete ekle! : " + urunAdi);

        }
    }
}
