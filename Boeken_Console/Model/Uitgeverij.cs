using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.Model
{
    public class Uitgeverij
    {
        #region Constructor voor Uitgeverij
        public Uitgeverij(string naam, string adres, string emailContact)
        {
            Naam = naam;
            Adres = adres;
            EmailContact = emailContact;
        }
        #endregion

        #region Properties voor Uitgeverij
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string EmailContact { get; set; }
        #endregion
    }
}
