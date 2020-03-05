using System.Collections.Generic;

namespace EfCodeFirst.Model
{
    public class Mitarbeiter : Person
    {
        public string Job { get; set; }
        public virtual ICollection<Kunde> Kunden { get; set; } = new HashSet<Kunde>();
        public virtual ICollection<Abteilung> Abteilungen { get; set; } = new HashSet<Abteilung>();

        public decimal Gehalt { get; set; }

        public int Schuhgöße { get; set; }
        public float AnzahlOhren { get; set; }
    }
}
