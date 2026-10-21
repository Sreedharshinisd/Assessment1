
using ASSESSMENT1.Models;
using ASSESSMENT1.Services;

namespace ASSESSMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService service = new CustomerService();

            while (true)
            {
                Console.WriteLine(" CUSTOMER MANAGEMENT ");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Display Customers");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Customer c = new Customer();

                        Console.Write("Enter ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id)
                            || id <= 0)
                        {
                            Console.WriteLine("Invalid ID");
                            break;
                        }

                        c.CustomerId = id;

                        Console.Write("Enter Name: ");
                        c.FullName = Console.ReadLine() ?? "";

                        Console.Write("Enter Phone: ");
                        c.PhoneNumber = Console.ReadLine() ?? "";

                        Console.Write("Enter Address: ");
                        c.Address = Console.ReadLine() ?? "";

                        service.AddCustomer(c);
                        break;

                    case "2":
                        service.DisplayCustomers();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
