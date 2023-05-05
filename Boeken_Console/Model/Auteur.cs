using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.Model
{
    public class Auteur
    {
        #region Constructor
        public Auteur(string naam, string emailContact)
        {
            Naam = naam;
            EmailContact = emailContact;
        }
        #endregion
        #region Properties
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailContact { get; set; }
        #endregion


    }
}
