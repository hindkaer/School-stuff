using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace CodeFirstDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonContext())
            {
                // Create and save a new Person
                Console.Write("Tilfoj fornavn for en ny Person: ");
                var fornavn = Console.ReadLine();
                Console.Write("Tilfoj mellemnavn for en ny Person: ");
                var mellemnavn = Console.ReadLine();
                Console.Write("Tilfoj efternavn for en ny Person: ");
                var efternavn = Console.ReadLine();
                Console.Write("Tilfoj typen for den nye Person: ");
                var persontype = Console.ReadLine();

                var person = new Person() { Fornavn = fornavn, Mellemnavn = mellemnavn, Efternavn = efternavn, Persontype = persontype};
                db.Persons.Add(person);
                db.SaveChanges();

                Console.WriteLine();

                // Display all Persons from the database and sort them by firstname
                var query = from b in db.Persons
                    orderby b.Fornavn
                    select b;

                Console.WriteLine("All Persons in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Fornavn, item.Mellemnavn, item.Efternavn);
                }
            }
        }
    }
    public class Person
    {
        public int PersonID { get; set; }
        public string Fornavn { get; set; }
        public string Mellemnavn { get; set; }
        public string Efternavn { get; set; }
        public string Persontype { get; set; }
    }

    public class Adresse
    {
        public int AdresseID { get; set; }
        public string Husnummer { get; set; }
        public string Vejnavn { get; set; }
        public string Postnummer { get; set; }
        public string Bynavn { get; set; }
    }

    public class Emailadresse
    {
        public int EMAILID { get; set; }
    }

    public class Noter
    {
        public int NoterID { get; set; }
    }

    public class Telefon
    {
        public int TelefonID { get; set; }
        public string Telefonnummer { get; set; }
        public string Telefonselskab { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Emailadresse> Emailadresses { get; set; }
        public DbSet<Noter> Notes { get; set; }
        public DbSet<Telefon> Telefons { get; set; }
    }
}
