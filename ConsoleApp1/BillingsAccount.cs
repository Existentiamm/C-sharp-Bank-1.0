using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BillingsAccount: Account
    {

        public BillingsAccount(string firstName, string lastName, string pesel, string county_of_Origin, string nationality, double accountNumber, decimal accountBalance)
            : base ( firstName,  lastName,  pesel, county_of_Origin,  nationality,  accountNumber, accountBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            County_of_Origin = county_of_Origin;
            Nationality = nationality;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
        }

        public override string AccountType()
        {
            return "KONTO ROZLICZENIOWE";
        }

    }




}
