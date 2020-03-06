using System.Collections.Generic;

namespace ppedv.Finex.Model
{
    public class Apotheke : Entity
    {
        public string Name { get; set; }
        public string Ort { get; set; }
        public virtual HashSet<Lager> Lager { get; set; } = new HashSet<Lager>();
    }
}
