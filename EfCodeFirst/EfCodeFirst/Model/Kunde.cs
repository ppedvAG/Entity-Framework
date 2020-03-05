using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.Model
{
    public class Kunde : Person
    {
        [MaxLength(17)]
        [Column("Kundennummer")]
        public string KdNummer { get; set; }
        public virtual Mitarbeiter Mitarbeiter { get; set; }

        public string Anrede { get; set; }
    }
}
