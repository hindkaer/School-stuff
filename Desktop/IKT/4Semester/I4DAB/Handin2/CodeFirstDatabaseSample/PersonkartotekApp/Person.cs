using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PersonkartotekApp
{
    public class Person
    {
        //public Person(string _Fornavn, string _Mellemnavn, string _Efternavn, string _Type)
        //{
        //    Fornavn = _Fornavn;
        //    Mellemnavn = _Mellemnavn;
        //    Efternavn = _Efternavn;
        //    Type = _Type;

        //    Telefons = new List<Telefon>();
        //    Emailadresses = new List<Emailadresse>();
        //    AlternativAdresses = new List<AlternativAdresse>();
        //    Notes = new List<Note>();
        //}

        public virtual long PersonID { get; set; }
        public virtual string Fornavn { get; set; }
        public virtual string Mellemnavn { get; set; }
        public virtual string Efternavn { get; set; }
        public virtual string Type { get; set; }
        public List<Telefon> Telefons { get; set; }
        public List<Emailadresse> Emailadresses { get; set; }
        public List<Adresse> Adresses { get; set; }
        public List<Note> Notes { get; set; }

    }





}
