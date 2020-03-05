using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirst_DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hallo Northwind");


            var con = new Model1();

            con.Customers.ToList().ForEach(x => Console.WriteLine(x.CompanyName));

            Console.ReadLine();

        }
    }
}
