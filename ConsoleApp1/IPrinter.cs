using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IPrinter
    {
        void Print(Account printer);
        //drukowanie. Jeżeli implementuje się interface to metda musi się znaleźć w danej klasie. Nie ma modyfikatora dostępu, bo wszystko ma być publiczne

        void getCompany(Company company);

    }


}
