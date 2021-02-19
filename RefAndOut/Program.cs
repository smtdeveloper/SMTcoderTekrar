using System;

namespace RefAndOut
{
    using System;

    class Program
    {

        // örnek1 - ref ve out kullanmadan
        static void Main(String[] args)
        {
            
            int sayi = 30;
            sayi = SayiEkle(sayi);                                 //Burada SayiEkle fonksiyonu çağrılır ve üzerine 30 ekleyip çıkan sonucu bize return olarak döndür.
            Console.WriteLine(" ref ve out yok : " + sayi);

            // örnek 2 ref kullanarak
            int sayiRef = 30;
            SayiEkleRef(ref sayiRef); // Sonuç 50'dir.
            Console.WriteLine(" ref : " + sayiRef);

            // örnek 3 out kullanarak
            int sayiout;
            SayiEkleOut(out sayiout, 30);
            Console.WriteLine(" Out : " + sayiout);

            Console.WriteLine("SMTcoder");
        }
        

        private static int SayiEkle(int sayi)
        {
            int sonuc = sayi + 20;
            return sonuc;
        }

         static void SayiEkleRef(ref int takmaAd)
        {
            takmaAd = takmaAd + 20;

        }

        static void SayiEkleOut(out int sayi, int i)
        {
            sayi = i + 20;
 }





    }
}


