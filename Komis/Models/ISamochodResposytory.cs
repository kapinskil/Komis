using System.Collections.Generic;

namespace Komis.Models
{
    public interface ISamochodResposytory
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodoID(int samochodID);
    }
}
