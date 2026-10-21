
using ASSESSMENT1.Models;
using System.Collections.Generic;

namespace ASSESSMENT1.Services
{
    public class CustomerService
    {
        List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer c)
        {
            customers.Add(c);
            Console.WriteLine("Customer added successfully");
        }

        public void DisplayCustomers()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID: " + c.CustomerId);
                Console.WriteLine("Name: " + c.FullName);
                Console.WriteLine("Phone: " + c.PhoneNumber);
                Console.WriteLine("Address: " + c.Address);
            }
        }
    }
}
