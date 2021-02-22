using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class CarsManager
    {
        public void Add(Cars cars)
        {
            Console.WriteLine(cars.Marka + " Arabayı Ekledin ");
        }

        public void Add2(string marka, int fiyat, string renk)
        {
            Console.WriteLine( marka + " Araba eklendi ");
        }
        
        public void Delete(Cars cars)
        {
            Console.WriteLine(cars.Marka + " Araba Silindi ");
        }
        public void GetAll(Cars cars)
        {
            Console.WriteLine(" Markası    : " + cars.Marka );
            Console.WriteLine(" Model Yılı : " + cars.ModelYılı);
            Console.WriteLine(" Fiyatı     : " + cars.Fiyat + " TL"); ;
            Console.WriteLine(" Renk       : " + cars.Renk);
        }
    }
}
