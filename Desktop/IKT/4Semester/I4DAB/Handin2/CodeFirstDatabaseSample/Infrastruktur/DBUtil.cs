﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PersonkartotekApp;


namespace Infrastuktur
{
    public class DBUtil
    {
        
        public DBUtil()
        { }

        private SqlConnection openConnection
        {
            get
            {
                var con = new SqlConnection("Data Source=st-i4dab.uni.au.dk;Initial Catalog=E18I4DABau570382;Persist Security Info=True;User ID=E18I4DABau570382;Password=E18I4DABau570382;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
                con.Open();
                return con;
            }
        }

       
        public void AddPersonDB(ref Person p)  // Tilføj en person
        {
            string insertStringParam = @"INSERT INTO [Person] (Fornavn, Mellemnavn, Efternavn, Type)
                                                    OUTPUT INSERTED.PersonID  
                                                    VALUES (@Fornavn, @Mellemnavn, @Efternavn,@Type)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Fornavn", p.Fornavn);
                cmd.Parameters.AddWithValue("@Mellemnavn", p.Mellemnavn);
                cmd.Parameters.AddWithValue("@Efternavn", p.Efternavn);
                cmd.Parameters.AddWithValue("@Type", p.Type);
                
                p.PersonID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdatePersonDB(ref Person p)  // Opdater en eksisterende person
        {
            string updateStringParam = @"UPDATE Person 
                                             SET Fornavn=@Fornavn, Mellemnavn=@Mellemnavn, Efternavn=@Efternavn, Type=@Type
                                             WHERE PersonID=@PersonID";
                                              

            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Fornavn", p.Fornavn);
                cmd.Parameters.AddWithValue("@Mellemnavn", p.Mellemnavn);
                cmd.Parameters.AddWithValue("@Efternavn", p.Efternavn);
                cmd.Parameters.AddWithValue("@Type", p.Type);
                cmd.Parameters.AddWithValue("@PersonID", p.PersonID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeletePersonDB(ref Person p)  // Slet en eksisterende person ud fra personID
        {
            string deleteString = @"DELETE FROM Person WHERE (PersonID = @PersonID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@PersonID", p.PersonID);

                var id = (long)cmd.ExecuteNonQuery();
                p = null;
            }
        }

        public List<Person> GetPerson() // Printer en liste af alle de eksisterende personer
        {
            string sqlcmd = @"SELECT * FROM Person";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Person> hver = new List<Person>();
                Person p = null;
                while (rdr.Read())
                {
                    p = new Person();
                    p.PersonID = (long)rdr["PersonID"];
                    p.Fornavn = (string)rdr["Fornavn"];
                    p.Mellemnavn = (string)rdr["Mellemnavn"];
                    p.Efternavn = (string)rdr["Efternavn"];
                    p.Type = (string)rdr["Type"];

                    hver.Add(p);
                }
                return hver;
            }

        }


        public void AddNoteDB(ref Note n)  // Tilføjer en note
        {
            string insertStringParam =
                @"INSERT INTO [Noter] (Note, Person) 
                OUTPUT INSERTED.NoteID VALUES (@Note, @Person)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Note", n.Noten);
                cmd.Parameters.AddWithValue("@Person", n.Person);

                n.NoteID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateNoteDB(ref Note n)  // Opdaterer en eksisterende note
        {
            string updateStringParam = @"UPDATE Noter 
                                             SET Note=@Note, Person=@Person
                                             WHERE NoteID=@NoteID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Note", n.Noten);
                cmd.Parameters.AddWithValue("@Person", n.Person);
                cmd.Parameters.AddWithValue("@NoteID", n.NoteID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteNoteDB(ref Note n)  // Sletter en eksisterende note
        {
            string deleteString = @"DELETE FROM Noter WHERE (NoteID = @NoteID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@NoteID", n.NoteID);

                var id = (long)cmd.ExecuteNonQuery();
                n = null;
            }
        }


        public List<Note> GetNoter() // Printer en liste af alle de eksisterende noter
        {
            string sqlcmd = @"SELECT * FROM Noter";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Note> notelist = new List<Note>();
                Note n = null;
                while (rdr.Read())
                {
                    n = new Note();
                    n.NoteID = (long)rdr["NoteID"];
                    n.Person = (long)rdr["Person"];
                    n.Noten = (string)rdr["Note"];

                    notelist.Add(n);
                }
                return notelist;
            }

        }


        public void AddEmailDB(ref Emailadresse e)  // Tilføjer en e-mail adresse
        {
            string insertStringParam =
                @"INSERT INTO [Emailadresse] (Email, Person) 
                OUTPUT INSERTED.EmailID VALUES (@Email, @Person)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@Person", e.Person);

                e.EmailID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateEmailDB(ref Emailadresse e)  // Opdaterer en eksisterende Email
        {
            string updateStringParam = @"UPDATE Emailadresse 
                                             SET Email=@Email, Person=@Person
                                             WHERE EmailID=@EmailID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@Person", e.Person);
                cmd.Parameters.AddWithValue("@EmailID", e.EmailID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmailDB(ref Emailadresse e)  // Sletter en eksisterende Email
        {
            string deleteString = @"DELETE FROM Emailadresse WHERE (EmailID = @EmailID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@EmailID", e.Email);

                var id = (long)cmd.ExecuteNonQuery();
                e = null;
            }
        }

        public List<Emailadresse> GetEmail() // Printer en liste af alle de eksisterende Emailadresser
        {
            string sqlcmd = @"SELECT * FROM Emailadresse";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Emailadresse> emaillist = new List<Emailadresse>();
                Emailadresse e = null;
                while (rdr.Read())
                {
                    e = new Emailadresse();
                    e.EmailID = (long)rdr["EmailID"];
                    e.Person = (long) rdr["Person"];
                    e.Email = (string)rdr["Email"];

                    emaillist.Add(e);
                }
                return emaillist;
            }
        }


        public void AddOperatoerDB(ref Operatoer o)  // Tilføjer en Operatør
        {
            string insertStringParam =
                @"INSERT INTO [Operatør] (Selskab, Telefon) 
                OUTPUT INSERTED.OperatørID VALUES (@Selskab, @Telefon)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Selskab", o.Selskab);
                cmd.Parameters.AddWithValue("@Telefon", o.Telefon);

                o.OperatoerID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateOperatoerDB(ref Operatoer o)  // Opdaterer en eksisterende Operatør
        {
            string updateStringParam = @"UPDATE Operatør 
                                             SET Selskab=@Selskab, Telefon=@Telefon
                                             WHERE OperatørID=@OperatørID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Selskab", o.Selskab);
                cmd.Parameters.AddWithValue("@Telefon", o.Telefon);
                cmd.Parameters.AddWithValue("@OperatørID", o.OperatoerID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOperatoerDB(ref Operatoer o)  // Sletter en eksisterende Operatør
        {
            string deleteString = @"DELETE FROM Operatør WHERE (OperatørID = @OperatørID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@OperatørID", o.OperatoerID);

                var id = (long)cmd.ExecuteNonQuery();
                o = null;
            }
        }

        public List<Operatoer> GetOperatoer() // Printer en liste af alle de eksisterende Operatører
        {
            string sqlcmd = @"SELECT * FROM Operatør";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Operatoer> operatoerlist = new List<Operatoer>();
                Operatoer o = null;
                while (rdr.Read())
                {
                    o = new Operatoer();
                    o.OperatoerID = (long)rdr["OperatørID"];
                    o.OperatoerID = (long)rdr["Telefon"];
                    o.Selskab = (string)rdr["Selskab"];

                    operatoerlist.Add(o);
                }
                return operatoerlist;
            }
        }

        public void AddCityDB(ref City c)  // Tilføjer en By
        {
            string insertStringParam =
                @"INSERT INTO [City] (Citynavn, Postnummer, Land, Adresse) 
                OUTPUT INSERTED.CityID VALUES (@Citynavn, @Postnummer, @Land, @Adresse)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Citynavn", c.Citynavn);
                cmd.Parameters.AddWithValue("@Postnummer", c.Postnummer);
                cmd.Parameters.AddWithValue("@Land", c.Land);
                cmd.Parameters.AddWithValue("@Adresse", c.Adresse);

                c.CityID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateCityDB(ref City c)  // Opdaterer en eksisterende By
        {
            string updateStringParam = @"UPDATE City 
                                             SET Citynavn=@Citynavn, Postnummer=@Postnummer, Land=@Land, Adresse=@Adresse
                                             WHERE CityID=@CityID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Citynavn", c.Citynavn);
                cmd.Parameters.AddWithValue("@Postnummer", c.Postnummer);
                cmd.Parameters.AddWithValue("@Land", c.Land);
                cmd.Parameters.AddWithValue("@Adresse", c.Adresse);
                cmd.Parameters.AddWithValue("@CityID", c.CityID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCityDB(ref City c)  // Sletter en eksisterende By
        {
            string deleteString = @"DELETE FROM City WHERE (CityID = @CityID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@CityID", c.CityID);

                var id = (long)cmd.ExecuteNonQuery();
                c = null;
            }
        }


        public List<City> GetCity() // Printer en liste af alle de eksisterende byer
        {
            string sqlcmd = @"SELECT * FROM City";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<City> citylist = new List<City>();
                City c = null;
                while (rdr.Read())
                {
                    c = new City();
                    c.CityID = (long)rdr["OperatørID"];
                    c.Citynavn = (string)rdr["Citynavn"];
                    c.Postnummer = (string)rdr["Postnummer"];
                    c.Land = (string)rdr["Land"];
                    c.CityID = (long)rdr["Adresse"];

                    citylist.Add(c);
                }
                return citylist;
            }
        }

        public void AddTelefonDB(ref Telefon t)  // Tilføjer en Telefon
        {
            string insertStringParam =
                @"INSERT INTO [Telefon] (Telefonnnummer, Person) 
                OUTPUT INSERTED.TelefonID VALUES (@Telefonnummer, @Person)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Telefonnummer", t.Telefonnummer);
                cmd.Parameters.AddWithValue("@Person", t.Person);

                t.TelefonID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateTelefonDB(ref Telefon t)  // Opdaterer en eksisterende Telefon
        {
            string updateStringParam = @"UPDATE Telefon 
                                             SET Telefonnummer=@Telefonnummer, Person=@Person
                                             WHERE TelefonID=@TelefonID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Telefonnummer", t.Telefonnummer);
                cmd.Parameters.AddWithValue("@Person", t.Person);
                cmd.Parameters.AddWithValue("@TelefonID", t.TelefonID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTelefonDB(ref Telefon t)  // Sletter en eksisterende Telefon
        {
            string deleteString = @"DELETE FROM Telefon WHERE (TelefonID = @TelefonID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@TelefonID", t.TelefonID);

                var id = (long)cmd.ExecuteNonQuery();
                t = null;
            }
        }

        public List<Telefon> GetTelefon() // Printer en liste af alle de eksisterende Telefoner
        {
            string sqlcmd = @"SELECT * FROM Telefon";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Telefon> telefonlist = new List<Telefon>();
                Telefon t = null;
                while (rdr.Read())
                {
                    t = new Telefon();
                    t.TelefonID = (long)rdr["TelefonID"];
                    t.TelefonID = (long)rdr["Person"];
                    t.Telefonnummer = (int)rdr["Telefonnummer"];

                    telefonlist.Add(t);
                }
                return telefonlist;
            }
        }

        public void AddAdresseDB(ref Adresse a)  // Tilføjer en Adresse
        {
            string insertStringParam =
                @"INSERT INTO [Adresse] (Vej, Husnummer, Person) 
                OUTPUT INSERTED.AdresseID VALUES (@Vej, @Husnummer, @Person)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, openConnection))
            {
                cmd.Parameters.AddWithValue("@Vej", a.Vej);
                cmd.Parameters.AddWithValue("@Husnummer", a.Husnummer);
                cmd.Parameters.AddWithValue("@Person", a.Person);


                a.AdresseID = (long)cmd.ExecuteScalar();
            }
        }

        public void UpdateAdresseDB(ref Adresse a)  // Opdaterer en eksisterende Adresse
        {
            string updateStringParam = @"UPDATE Adresse 
                                             SET Vej=@Vej, Husnummer=@Husnummer, Person=@Person
                                             WHERE AdresseID=@AdresseID";


            using (SqlCommand cmd = new SqlCommand(updateStringParam, openConnection))
            {
                // Get your parameters ready                    
                cmd.Parameters.AddWithValue("@Vej", a.Vej);
                cmd.Parameters.AddWithValue("@Husnummer", a.Husnummer);
                cmd.Parameters.AddWithValue("@Person", a.Person);
                cmd.Parameters.AddWithValue("@AdresseID", a.AdresseID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAdresseDB(ref Adresse a)  // Sletter en eksisterende Adresse
        {
            string deleteString = @"DELETE FROM Adresse WHERE (AdresseID = @AdresseID)";
            using (SqlCommand cmd = new SqlCommand(deleteString, openConnection))
            {
                cmd.Parameters.AddWithValue("@AdresseID", a.AdresseID);

                var id = (long)cmd.ExecuteNonQuery();
                a = null;
            }
        }

        public List<Adresse> GetAdresse() // Printer en liste af alle de eksisterende Adresser
        {
            string sqlcmd = @"SELECT * FROM Adresse";
            using (var cmd = new SqlCommand(sqlcmd, openConnection))
            {
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                List<Adresse> adresselist = new List<Adresse>();
                Adresse a = null;
                while (rdr.Read())
                {
                    a = new Adresse();
                    a.AdresseID = (long)rdr["AdresseID"];
                    a.AdresseID = (long)rdr["Person"];
                    a.Vej = (string)rdr["Vej"];
                    a.Husnummer = (string)rdr["Husnummer"];

                    adresselist.Add(a);
                }
                return adresselist;
            }
        }
    }
}
