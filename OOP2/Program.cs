using System;

namespace OOP2
{
    class Program
    { 
        //SOLID
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = 123;
            customer1.Id = 2;
            customer1.Name = "Ece";
            customer1.LastName = "Akın";
            customer1.NationalIdentity = "123456";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 1;
            customer2.TaxNumber = 123;
            customer2.CompanyName = "kodlama.io";
            customer2.CustomerNumber = 123456;

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Add(customer4);

        }
    }
}
