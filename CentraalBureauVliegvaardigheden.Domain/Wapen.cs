namespace CentraalBureauVliegvaardigheden.Domain
{
    public class Wapen
    {
        public string Naam { get; set; }
        public SchadeType SchadeType { get; set; }
        public int EnergieVerbruik { get; set; }
        public int Gewicht { get; set; }
    }

    public enum SchadeType
    {
        Projectiel,
        Hitte,
        Bevriezing,
        Electrisch,
        Zwaartekracht
    }
}
