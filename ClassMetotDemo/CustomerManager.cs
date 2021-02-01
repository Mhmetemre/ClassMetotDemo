using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void List(Customer customer)
        {
            Console.WriteLine("Müüşteri Adı : " + customer.CusName + " " + customer.CusSurname + " " + "Müşteri Telefon Numarası : " + " " + customer.CusPhoneNum);
        }

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CusName + " " + customer.CusSurname + " " + "Adlı müşteri başarıyla eklendi!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CusName + " " + customer.CusSurname + " " + "Adlı müşteri başarıyla silindi!");
        }
    }
}
