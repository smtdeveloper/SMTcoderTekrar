using System;

namespace SMTcoderTekrar
{
    class Program
    {
        static void Main(string[] args)
        {

            // veritipi  değişkenadı;

            int sayi = 5;
            int x, y = 8, z;
            int  sayi1 = 10;
            int sayi2 = 20;
            
            sayi1 = 5;
            

            Console.WriteLine(sayi1);



            //Aynı türdeki değişkenler aynı anda tanımlanabilir.
            bool aktif = true;
            float f = 5.4f; // Değerin sonuna eklediğimiz f harfi değişkenin float türünde olduğunu gösterir.
            // float	4 Byte
            double d = 3.2;
            // double	8 Byte
            byte b = 255; // 0 - 255 arası
            // byte 8 Byte
            int i = 999999999; // -2.147.483.648 ile 2.147.483.647
            long l = 123456789;
            short s = -312;
            decimal dec = -5.26m; //Değerin sonundaki m harfi değişkenin decimal türünde olduğunu gösterir.
            char ch = 'c';  //Char tipinde ki değişkenler tek tırnak içerisine yazılır
            String deger ="merhaba";



            Console.WriteLine("Hello World!");

        }
    }
}
