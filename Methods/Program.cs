using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Örnek 1
             
            string produckname = "apple";
            double unitprice = 50;
            string explanation = "red apple";

            Console.WriteLine(" Produck Name : " + produckname);
            Console.WriteLine(" Unit Price   : " + unitprice);
            Console.WriteLine(" Explanation  : " + explanation);

            Console.WriteLine("örnek ---------01");

    */

            // örnek 2

            Produck produck1 = new Produck();
            produck1.categoryId = 1;
            produck1.Name = "apple";
            produck1.Price = 45;
            produck1.Explanation = "yellow apple";
            produck1.Stock = 10;

            Produck produck2 = new Produck();
            produck2.categoryId = 1;
            produck2.Name = "Banana";
            produck2.Price = 80;
            produck2.Explanation = "yellow Banana";
            produck2.Stock = 20;

            Produck produck3 = new Produck();
            produck3.categoryId = 1;
            produck3.Name = "lemon";
            produck3.Price = 25;
            produck3.Explanation = "Green lemon";
            produck3.Stock = 30;

            Produck produck4 = new Produck();
            produck4.categoryId = 2;
            produck4.Name = "potato ";
            produck4.Price = 20;
            produck4.Explanation = "potato field large ";
            produck4.Stock = 500;


            /**
            Produck[] producks = new Produck[] { produck1, produck2, produck3 };

            foreach (var produck in producks)
            {
                Console.WriteLine(" produck.Name  : " + produck.Name);
                Console.WriteLine(" produck.Price : " + produck.Price);
                Console.WriteLine(" produck.Explanation : " + produck.Explanation);
                Console.WriteLine(" produck.Stock : " + produck.Stock);
                Console.WriteLine("------------------");
            }
    */

            // örnek 3 - add
            Console.WriteLine("örnek 3");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(produck1);
            sepetManager.Ekle(produck2);
            sepetManager.Ekle(produck3);
            sepetManager.Ekle(produck4);

            // örnek 4 - add
            Console.WriteLine("örnek 4");

            sepetManager.Ekle2("elma", 12.5, "Amasya elması", 120);
            sepetManager.Ekle2("Muz", 55.8, "Yerli Muz", 80);

            //örnek 5  - DELETE
            sepetManager.Sil(produck2);
            sepetManager.Sil(produck1);

            // örnek 6 - UPDATE
            sepetManager.Guncele(produck4);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------SMTcoder");


        }
    }
}
