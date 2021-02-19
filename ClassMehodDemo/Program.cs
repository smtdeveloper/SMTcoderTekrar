using System;

namespace ClassMehodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Cinsiyet = "Erkek";
            customer1.isim = "Samet";
            customer1.SoyIsım = "Akca";
            customer1.Adres = "Kütahya / Merkez";
            customer1.Telofon = 0543433433;

            Customer customer2 = new Customer();
            customer2.Cinsiyet = "Kız";
            customer2.isim = "Eda";
            customer2.SoyIsım = "Cakır";
            customer2.Adres = "İstanbul";
            customer2.Telofon = 0541234595;



            Customer customer3 = new Customer();
            customer3.Cinsiyet = "Kız";
            customer3.isim = "Nazlı";
            customer3.SoyIsım = "Cekic";
            customer3.Adres = "Balıkkesir / Merkez";
            customer3.Telofon = 0543433698;

            Customer customer4 = new Customer();
            customer4.Cinsiyet = "Kız";
            customer4.isim = "Sinem";
            customer4.SoyIsım = "Oktay";
            customer4.Adres = "Bursa / Merkez";
            customer4.Telofon = 0543433643;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            foreach (var customer in customers)
            {
                Console.WriteLine(" Cinsiyet : " + customer.Cinsiyet);
                Console.WriteLine(" isim     : " + customer.isim);
                Console.WriteLine(" SoyIsım  : " + customer.SoyIsım);
                Console.WriteLine(" Adres    : " + customer.Adres);
                Console.WriteLine(" Telofon  : " + customer.Telofon);
                Console.WriteLine("-------------------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);
            customerManager.Ekle(customer3);
            customerManager.Ekle(customer4);

            Console.WriteLine("   ");

            customerManager.Sil(customer4);

            Console.WriteLine("   ");

            customerManager.Listele(customer2);
            customerManager.Listele(customer3);





            Console.WriteLine("");
            Console.WriteLine("Hello World!");
        }
    }
}
