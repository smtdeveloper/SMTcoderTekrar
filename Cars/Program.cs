using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars Pejo307 = new Cars();
            Pejo307.Marka = " Pejo 307 ";
            Pejo307.ModelYılı = 2003;
            Pejo307.Fiyat = 60000;
            Pejo307.Renk = "Mavi";
            Pejo307.Vites = "Tam Otomatik";

            Cars PejoPatner = new Cars();
            PejoPatner.Marka = "Pejo Patner";
            PejoPatner.ModelYılı = 2014;
            PejoPatner.Fiyat = 70000;
            PejoPatner.Renk = "Toz Rengi";
            PejoPatner.Vites = "5 Vitesli";

            
            Cars[] cars = new Cars[] { Pejo307, PejoPatner };

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(" Markası    : " + car.Marka);
            //    Console.WriteLine(" Model Yılı : " + car.ModelYılı);
            //    Console.WriteLine(" Fiyatı     : " + car.Fiyat + " TL"); ;
            //    Console.WriteLine(" Renk       : " + car.Renk);
            //    Console.WriteLine("---------------------------------43");
            //}

            //Console.WriteLine(" Araç Sayısı  : " + cars.Length);

            CarsManager carsManager = new CarsManager();
            carsManager.Add(Pejo307);

            carsManager.Add2(" Opel", 20000, " siyah");

            carsManager.Delete(PejoPatner);

            carsManager.GetAll(Pejo307);


            Console.WriteLine("--------");
            Console.WriteLine("SMTcoder");

        }
    }
}
