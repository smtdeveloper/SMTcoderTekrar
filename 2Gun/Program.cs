using System;
using System.Dynamic;

namespace _2Gun
{
    class Program
    {
        static void Main(string[] args)
        {

            // if else örneği

            //Console.WriteLine("1.Notu Girin : ");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Notu Girin:");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //double ort = (not1 + not2) / 2;

            //bool c = true;

            //if (c == false)   // == atama operatörü
            //    Console.WriteLine("Erkek");
            //else
            //    Console.WriteLine("Kadın");

            // Conditional ve Ternary Operatorler

            // Ternary Operatorler 
            // Ternary operatörü üç işlem alan tek operatördür. Bir bakıma if else yapısına da çok benzerlik göstermektedir.

            // Conditional Operatorler
            // Coalescing operatörü eğer gelen değerimiz null içeriyorsa bizim tanımlamış olduğumuz varsayılan değer atamasını yapar.

            // Ternary Operatörü Kullanımı: koşul ? doğru ise burası : yanlış ise burası çalışsın

            //Coalescing Kullanımı : değişkenimiz ?? varsayılan değerimiz


            //Ternary Operatorler 

            // Parse = Parse metodu, string türündeki bir veriyi, belirtilen bir veri türüne
            // dönüştürmede kullanılır. String ve object veri türleri haricindeki veri türleri ile birlikte kullanılabilmektedir.
            // System class'ında olan bir metottur.

            //Console.Write("[1-10] arasında sayı giriniz :");


            //Ternary Operatorler 


            //Console.Write("sifre  gir : ");
            //int sayi = int.Parse(Console.ReadLine());
            //string cevap = "";
            //cevap += sayi == 1234 ? "Bilgisayar acılıyor" : "Yanlış cevap";
            //Console.WriteLine(cevap);


            //string sifre = "samet43";
            //string nazlı = Msifre;

            //if (Msifre == Msifre)
            //{
            //    Console.WriteLine("Bilgisayar acılıyor");
            //}
            //else
            //{
            //    Console.WriteLine("sifre Hatalı");
            //}





            // Coalescing Kullanımı
            //Console.WriteLine("Yasını gir");
            //string yas = Console.ReadLine();
            //string sonuc = "";

            //sonuc = (yas == " " ? null : yas) ?? "boş gecildi. ";
            //Console.WriteLine( "Yasınız : " + sonuc  ); 




            // yapı şu şekildedir:


            //bool durumu = true;
            //string son2uc = durumu == true ? "Onaylanmış" : "Beklemede";



            // Switch Case Yapısı Kullanımı


            string renk = "sarı";

            switch (renk)
            {
                case "kırmızı":
                    Console.WriteLine("dur ");
                    break; // break dögüden cıkıs 
                case "sarı":
                    Console.WriteLine("hazır");
                    break;
                case "yesil":
                    Console.WriteLine("gec ");
                    break;

                default:
                    Console.WriteLine("ARIZALI");
                    break;
            }



        }
    }
}
