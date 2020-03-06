using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDB_NoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Auto() { PS = 555, Name = "Brum Burmm" };

            using (var db = new LiteDatabase(@"C:\Temp\MyData222.db"))
            {
                 var table = db.GetCollection<Auto>("Autos");
                // table.Insert(a);

                foreach (var item in table.Query().ToList())
                {
                    Console.WriteLine(item.Name);
                }

                //var results = table.Query();.Where(x => x.Name.StartsWith("J")).OrderBy(x => x.Name).Select(x => new { x.Name, NameUpper = x.Name.ToUpper() }).Limit(10).ToList();


            }
            Console.WriteLine("Ende");
            Console.ReadLine();
        }



    }

    class Auto
    {

        public int PS { get; set; }

        public string Name { get; set; }

    }


}
