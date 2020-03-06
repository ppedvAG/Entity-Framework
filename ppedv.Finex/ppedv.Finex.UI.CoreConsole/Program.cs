using ppedv.Finex.Logic;
using ppedv.Finex.Model;
using System;

namespace ppedv.Finex.UI.CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** FINEX ***");

            var core = new Core();
            foreach (var med in core.Repository.GetAll<Medikament>())
            {
                Console.WriteLine($"{med.Name} {med.Nummer} {med.Preis:c}");
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
