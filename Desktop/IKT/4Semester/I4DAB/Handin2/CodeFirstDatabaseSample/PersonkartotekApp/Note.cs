using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Note
    {
        public virtual string Noten { get; set; }

        public virtual long NoteID { get; set; }

        public virtual long Person { get; set; }


        //public Note(string _Noten)
        //{
        //    Noten = _Noten;
        //}
    }
}
