using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class AlternativAdresse
    {
        public virtual long PersonID { get; set; }
        public virtual long AdresseID { get; set; }
        public virtual long CityID { get; set; }
        public virtual string Type { get; set; }

        //public AlternativAdresse(string _Type)
        //{
        //    Type = _Type;
        //}
    }
}
