using System.Collections.Generic;
using CentraalBureauVliegvaardigheden.Domain;

namespace CentraalBureauVliegvaardigheden.Service
{
    public interface ICentraalBureauVliegvaardigheden
    {
        IEnumerable<Romp> AlleRompen();
        IEnumerable<Wapen> AlleWapens();
        IEnumerable<Vleugel> AlleVleugels();
        IEnumerable<Motor> AlleMotoren();
        double BepaalWerkelijkDraagvermogen(Romp romp);
        string RegisteerSchip(string JSONString);
    }
}
