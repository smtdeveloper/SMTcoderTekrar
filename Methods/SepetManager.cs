using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax yazım şekli
      
        public void Ekle(Produck produck)
        {
            Console.WriteLine ( produck.Name + "  Sepete Eklendi ");
        }
        public void Ekle2(string isim, double fiyat, string aciklama, int stok )
        {
            Console.WriteLine("Sepete Eklendi " + isim);
        }

        public void Sil(Produck produck)
        {
            Console.WriteLine(produck.Name + " : Sepetden silindi ");
        }
        public void Guncele(Produck produck)
        {
            Console.WriteLine(   produck.Name = "  Stokda Kalmadı - " + produck.Name);  
        }

    }
}
