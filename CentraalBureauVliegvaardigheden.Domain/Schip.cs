using System.Collections.Generic;

namespace CentraalBureauVliegvaardigheden.Domain
{
    public class Schip
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Romp Romp { get; set; }
        public List<Vleugel> Vleugels { get; set; }
        public Motor Motor { get; set; }
    }
}
