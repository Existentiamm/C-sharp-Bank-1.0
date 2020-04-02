using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Printer : IPrinter
    {
        public void getCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public void Print(Account account) {
            Console.WriteLine("Account  Type: {0}", account.AccountType());
            Console.WriteLine("LegalForm: {0}", account.AccountType());
            Console.WriteLine("FirstName: {0}", account.FirstName);
            Console.WriteLine("LastName: {0} ", account.LastName);
            Console.WriteLine("Pesel: {0}", account.Pesel);
            Console.WriteLine("CountyOfOrigin: {0}", account.County_of_Origin);
            Console.WriteLine("Nationality: {0}", account.Nationality);
            Console.WriteLine("AccountNumber: {0}", account.AccountNumber);
            Console.WriteLine("AccountBalance: {0}", account.AccountBalance);


        }

       
    }
}
