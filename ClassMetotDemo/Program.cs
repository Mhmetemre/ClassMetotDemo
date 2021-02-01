using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CusId = 1111;
            customer1.CusName = "Customer1";
            customer1.CusSurname = "Customer1Surname";
            customer1.CusPhoneNum = 111111111;

            Customer customer2 = new Customer();
            customer2.CusId = 2222;
            customer2.CusName = "Customer2";
            customer2.CusSurname = "Customer2Surname";
            customer2.CusPhoneNum = 222222222;

            Customer customer3 = new Customer();
            customer3.CusId = 3333;
            customer3.CusName = "Customer3";
            customer3.CusSurname = "Customer3Surname";
            customer3.CusPhoneNum = 333333333;

            CustomerManager customerManager = new CustomerManager();
            Customer[] customerlist = new Customer[] { customer1, customer2, customer3 };

            //LİST 
            Console.WriteLine("----------Customer List----------");

            foreach (var customer in customerlist)
            {
                customerManager.List(customer);
            }

            //ADD
            Console.WriteLine("----------Customer Add----------");

            customerManager.Add(customer1);

            //DELETE
            Console.WriteLine("----------Customer Delete----------");

            customerManager.Delete(customer3);
        }
    }
}
