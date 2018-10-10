using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Telefon
    {
        //public Telefon(int _Telefonnummer, Operatoer _Operatoer)
        //{
        //    Telefonnummer = _Telefonnummer;
        //    OperatoerID = _Operatoer.OperatoerID;
        //}

        public virtual int Telefonnummer { get; set; }
        public virtual long Person { get; set; }
        public virtual long TelefonID { get; set; }

        public virtual ICollection<Operatoer> operatører { get; set; }
    }
}
