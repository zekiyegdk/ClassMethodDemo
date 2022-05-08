using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Zekiye";
            customer1.Surname = "Gedik";
            customer1.Gender = "Kadın";
            customer1.Age = 24;


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ayşe";
            customer2.Surname = "Ak";
            customer2.Gender = "Kadın";
            customer2.Age = 35;

            //Müşteri bilgilerini dizi de tutmak
            Customer[] customers = new Customer[] { customer1, customer2 };

            //Yeni müşteri eklemesi
            Console.WriteLine("Bankaya Müşteri Eklemek");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("----------------------------------------------");

            //Müşteri bilgileri listelenmesi
            Console.WriteLine("Eklenen Müşterilerin Bilgileri");
            foreach (Customer item in customers)
            {
                Console.WriteLine(item.Id + " " +item.Name+ " " +item.Surname+ " " +item.Gender+ " " +item.Age);
             
            }

            Console.WriteLine("-----------------------------------------------");

            //Kayıtlı müşteri silinmesi
            Console.WriteLine("Müşteri Silinmesi");
            customerManager.Delete(customer2);


           

        }
    }
}
