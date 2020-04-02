using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Autor : Karolina Lubczyk");
            Console.WriteLine("Projekt:  Bank");

            SavingsAccount savingsAccount1 = new SavingsAccount("Grazyna", "iJanusz", "9711280381", "Sloviac", "Polandia", 123456789, 0.0M);
            BillingsAccount billingsAccount1 = new BillingsAccount("Janusz", "Wiesniok", "76648293728", "Sloviak", "Polandia", 123456756, 1.2M);
            Company company1 = new Company("Grazyno-bus", "dzialanosc_gospodarcza", 98654224738, 345723571234, "Grazyna", "iJanusz", "9711280381", "Sloviac", "Polandia", 123456789, 0.0M);
            IPrinter printer  = new Printer(); // korzystamy z interfejsu

            
            printer.Print(savingsAccount1);
            printer.Print(billingsAccount1);
            printer.Print(company1);

            
            Console.ReadKey();
        }
    }
}
