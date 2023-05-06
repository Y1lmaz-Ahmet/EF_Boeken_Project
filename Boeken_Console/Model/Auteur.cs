using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.Model
{
    public class Auteur
    {
        #region Constructor voor Auteur
        public Auteur(string naam, string emailContact)
        {
            Naam = naam;
            EmailContact = emailContact;
        }
        #endregion

        #region Properties voor Auteur
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailContact { get; set; }
        #endregion


    }
}
