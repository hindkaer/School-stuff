using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Operatoer
    {
        //public Operatoer(string _Selskab)
        //{
        //    Selskab = _Selskab;
        //    Telefoner = new List<Telefon>();
        //}
        
        public virtual long OperatoerID { get; set; }
        public virtual string Selskab { get; set; }

        public virtual long Telefon { get; set; }

    }
}
