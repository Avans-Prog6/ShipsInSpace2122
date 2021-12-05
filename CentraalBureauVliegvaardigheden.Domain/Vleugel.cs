using System.Collections.Generic;

namespace CentraalBureauVliegvaardigheden.Domain
{
    public class Vleugel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Energie { get; set; }
        public int Gewicht { get; set; }
        public List<Wapen> Hardpoint { get; set; }
        public int NumberOfHardpoints { get; set; }
    }
}
