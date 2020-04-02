using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Company: Account
    {
        public string NameOfCompany { get; set; }
        public string LegalForm { get; set; }
        public float Regon { get; set; }
        public float Nip { get; set; }

        public Company(string nameOfCompany, string legalForm, float regon, float nip,
            string firstName, string lastName, string pesel, string county_of_Origin, string nationality,
            double accountNumber, decimal accountBalance)
            : base(firstName, lastName, pesel, county_of_Origin, nationality, accountNumber, accountBalance)
        {
            NameOfCompany = nameOfCompany;
            LegalForm = legalForm;
            Regon = regon;
            Nip = nip;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            County_of_Origin = county_of_Origin;
            Nationality = nationality;
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;


        }

        public void getCompany(Company company) {
            Console.WriteLine(company.NameOfCompany, company.LegalForm, company.Regon, company.Nip);
        } 

        public override string AccountType()
        {
            return "KONTO FIRMOWE ";
        }

    }


    }

