using System.ComponentModel.DataAnnotations;

namespace CentraalBureauVliegvaardigheden.Domain
{
    public class Romp
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Draagvermogen Draagvermogen { get; set; }
    }

    public enum Draagvermogen
    {
        Interceptor = 600,
        LightFighter = 950,
        MediumFighter = 1000,
        Tank = 1400,
        HeavyTank = 2000
    }
}
