    using System;
using System.Dynamic;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(5, 5));
            //Console.WriteLine(dortIslem.Topla2());


            // Reflection yazılısı ve kullanısı  

            var tip = typeof(DortIslem);

            //DortIslem dortIslem =(DortIslem)Activator.CreateInstance(tip,2,3);
            //Console.WriteLine(" Topla  : " + dortIslem.Topla( 5,5));
            //Console.WriteLine(" Topla2 : " + dortIslem.Topla2());

            var intance = Activator.CreateInstance(tip, 5, 6);
            MethodInfo methodInfo = intance.GetType().GetMethod("Topla2");
            Console.WriteLine(" intance Topla2 : " + methodInfo.Invoke(intance, null));

            Console.WriteLine("----------");

            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod Adı : {0}" , info.Name);
                foreach (var Parametlere in info.GetParameters())
                {
                    Console.WriteLine(" Parametlere : {0}" , Parametlere.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine(" Attribute : {0}" , attribute.GetType().Name);
                }
            }

            Console.ReadLine();
          
        }


        public class DortIslem
        {
           private int _sayi1;
           private int _sayi2;
            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public int Topla(int sayi1 , int sayi2)
            {
                return sayi1 + sayi2; 

            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;

            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;

            }
             
            [MetodName("Carma")]  // attribute
            public int Carp2()
            {
                return _sayi1 * _sayi2;

            }

        }

    }

    class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }

}
