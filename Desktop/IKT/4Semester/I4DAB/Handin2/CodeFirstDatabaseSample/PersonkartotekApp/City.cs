using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class City
    {
        public virtual long CityID { get; set; }

        public virtual string Postnummer { get; set; }

        public virtual string Citynavn { get; set; }
        public virtual string Land { get; set; }



        public City(string _Postnummer, string _Citynavn, string _Land)
        {
            Postnummer = _Postnummer;
            Citynavn = _Citynavn;
            Land = _Land;
        }

    }
}
