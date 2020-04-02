using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Account//klasa abstrakcyjna
    {

        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string County_of_Origin { get; set; }
        public string Nationality { get; set; }
        public double AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }

        public Account(string firstName, string lastName, string pesel,
            string county_of_Origin, string nationality, double accountNumber, decimal accountBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            County_of_Origin = county_of_Origin;
            Nationality = nationality;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        } //konstruktor


        //1)metoda abstrakcyjna(szablon dla innych metod)
        //2)jeżeli to metoda abstrakcyjna to bez deklaracji treści
        //3) musimy użyć override w klasach, które dziedzicza
        public abstract string AccountType(); 
    }
}
