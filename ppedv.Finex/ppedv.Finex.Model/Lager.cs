namespace ppedv.Finex.Model
{
    public class Lager : Entity
    {
        public virtual Apotheke Apotheke { get; set; }
        public virtual Medikament Medikament { get; set; }
        public int Bestand { get; set; }
    }
}
