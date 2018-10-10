using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Emailadresse
    {
        public virtual string Email { get; set; }

        public virtual long Person { get; set; }
        public virtual long EmailID { get; set; }

        //public Emailadresse(string _Email)
        //{
        //    Email = _Email;
        //}
    }
}
