using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMehodDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine(customer.isim + " Eklendi ");
        }
        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.isim + " Silindi ");
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine(customer.isim + " Listelendi ");
        }

    }
}
