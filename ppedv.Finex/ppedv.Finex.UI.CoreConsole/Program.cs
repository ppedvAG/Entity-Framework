using ppedv.Finex.Logic;
using ppedv.Finex.Model;
using System;
using System.Linq;
using System.Text;

namespace ppedv.Finex.UI.CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** FINEX ***");

            var core = new Core();
            foreach (var med in core.Repository.Query<Medikament>()
                                               .Where(x => x.Modified.Year > 100)
                                               .OrderBy(x => x.Lager.Sum(l => l.Bestand))
                                               .ThenBy(x => x.Name)
                                               .ToList())
            {
                Console.WriteLine($"[{med.Lager.Sum(l => l.Bestand)}] {med.Name} {med.Nummer} {med.Preis:c}");
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
