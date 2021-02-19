using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Samet Akca";
            int yas = 21;
            int tercubeYılı = 3;


            Kurs Javakurs = new Kurs();
            Javakurs.Eğitmen = "Samet Akca ";
            Javakurs.KursAdi = "Java Geliştirici Kursları";
            Javakurs.KursSayisi = 3;
            Javakurs.OgrenciSayisi = 50;

            Kurs Chsapkurs = new Kurs();
            Chsapkurs.Eğitmen = "Eda Cakır";
            Chsapkurs.KursAdi = "C # geliştirici Kursları";
            Chsapkurs.KursSayisi = 5;
            Chsapkurs.OgrenciSayisi = 1500;

            Kurs Cplusskurs = new Kurs();
            Cplusskurs.Eğitmen = "Nazlı cekic";
            Cplusskurs.KursAdi = "C++ geliştirici Kursları";
            Cplusskurs.KursSayisi = 2;
            Cplusskurs.OgrenciSayisi = 20;

            Kurs[] kurslar = new Kurs[] {Javakurs, Chsapkurs , Cplusskurs };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine("  Eğitmen Adı" + kurs.Eğitmen);
                Console.WriteLine(" KURS Adı " + kurs.KursAdi);
                Console.WriteLine(" Kurs Sayısı " + kurs.KursSayisi);
                Console.WriteLine(" Öğrenci Sayısı " +kurs.OgrenciSayisi);
                Console.WriteLine("");
                Console.WriteLine("-------- SMTcoder -----------");
                Console.WriteLine("");


            }



 
        }

       
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int OgrenciSayisi { get; set; }

        public int KursSayisi { get; set; }
    }
}
