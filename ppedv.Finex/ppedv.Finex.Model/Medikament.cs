using System.Collections.Generic;

namespace ppedv.Finex.Model
{
    public class Medikament : Entity
    {
        public string Name { get; set; }
        public string Nummer { get; set; }
        public int Packungsgröße { get; set; }
        public decimal Preis { get; set; }
        public virtual HashSet<Lager> Lager { get; set; } = new HashSet<Lager>();
    }
}
