using System;
using System.Collections.Generic;

namespace swe_project.Modelle
{
    public class Benutzer
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public bool Positiv { get; set; }
        public DateTime Ablauf { get; set; }



        public Benutzer()
        {
            
        }

        public Benutzer(int id, string vorname, string nachname, string email, bool positiv, DateTime ablauf)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
            Positiv = positiv;
            Ablauf = ablauf;
        }

        public List<Benutzer> Filter (bool alle, int id, string nachname, string vorname)
        {
            if (alle == true)
            {

            }
            else
            {

            }
        }

        public bool BenutzerAnlegen(int id, string vorname, string nachname, string email)
        {
            return true;
        }

        public bool BenutzerLoeschen (int id)
        {
            return false;
        }

    }

    
}
