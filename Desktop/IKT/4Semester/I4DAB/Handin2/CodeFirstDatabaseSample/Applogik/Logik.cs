using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Infrastuktur;
using PersonkartotekApp;

namespace Applogik
{
    public class Logik
    {
        public void TheApp()
        {
            DBUtil utilitiy = new DBUtil();
            Person person1 = new Person() { Fornavn = "Simon", Mellemnavn = "Møller", Efternavn = "Hindkaer", Type = "Mand"};

            Adresse adresse1 = new Adresse() {Vej = "Gyldenløvesgade", Husnummer = "6, 2 sal th"};

            City city1 = new City(){Citynavn="Aarhus N", Postnummer = "8200"};

            Emailadresse email1 = new Emailadresse() {Email = "hindkaer_msn@hotmail.com", EmailID = 7};

            Telefon telefon1 = new Telefon() {Telefonnummer = 20668161};

            Note note1 = new Note() {Noten = "Studerende på AU", NoteID = 2};

            Operatoer operatør1 = new Operatoer(){Selskab = "TDC"};



            utilitiy.AddPersonDB(ref person1);       // Tilføjer person1 til databasen
            //utilitiy.AddAdresseDB(ref adresse1);     // Tilføjer adresse1 til databasen
            //utilitiy.AddCityDB(ref city1);           // Tilføjer city1 til databasen
            //utilitiy.AddEmailDB(ref email1);         // Tilføjer email1 til databasen
            //utilitiy.AddTelefonDB(ref telefon1);     // Tilføjer telefon1 til databasen
            //utilitiy.AddNoteDB(ref note1);           // Tilføjer note1 til databasen
            //utilitiy.AddOperatoerDB(ref operatør1);  // Tilføjer operatør1 til databasen

            //email1.Email = "hindkidinkidoo@gmail.com"; 
            //utilitiy.UpdateEmailDB(ref email1);         //Opdaterer email1

            //utilitiy.DeleteAdresseDB(ref adresse1);        // Sletter adresse1
            //utilitiy.DeleteCityDB(ref city1);              // Sletter city1
            //utilitiy.DeleteEmailDB(ref email1);            // Sletter email1
            //utilitiy.DeleteTelefonDB(ref telefon1);        // Sletter telefon1
            //utilitiy.DeleteNoteDB(ref note1);              // Sletter note1
            //utilitiy.DeleteOperatoerDB(ref operatør1);     // Sletter operatør1


            //utilitiy.GetPerson();     // Viser alle personer i databasen
            //utilitiy.GetAdresse();    // Viser alle adresser i databasen
            //utilitiy.GetCity();       // Viser alle byer i databasen
            //utilitiy.GetEmail();      // Viser alle emails i databasen
            //utilitiy.GetTelefon();    // Viser alle telefoner i databasen
            //utilitiy.GetNoter();      // Viser alle noter i databasen
            //utilitiy.GetOperatoer();  // Viser alle operatører i databasen
        }


    }
}
