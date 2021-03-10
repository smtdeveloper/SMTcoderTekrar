using System;
using System.Runtime.CompilerServices;

namespace Attribute
{
   public class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, LastName = "AKCA", Age = 22 };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine(); 
            Console.WriteLine("SMTcoder");

        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
       [RequiredProperty]   // Zorunlu alan -- attribute ile yapımı 
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
       
        public int Age { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} , {1} , {2} , {3} Eklendi ! " , 
                 customer.Id , customer.FirstName , customer.LastName , customer.Age);
        }
    }

     class RequiredPropertyAttribute : Attribute
    {

    }

    class ToTableAttribute :Attribute
    {


    }

}
