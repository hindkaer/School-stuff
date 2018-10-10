using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Adresse
    {
        public virtual long AdresseID { get; set; }
        public virtual long Person { get; set; }
        public virtual string Vej { get; set; }
        public virtual string Husnummer { get; set; }

        public virtual ICollection<City> cities { get; set; }

        //public Adresse(string _Vej, string _Husnummer)
        //{
        //    Vej = _Vej;
        //    Husnummer = _Husnummer;
        //}
    }
}
