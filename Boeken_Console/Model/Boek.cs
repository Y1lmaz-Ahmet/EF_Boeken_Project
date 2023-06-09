﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.Model
{
    public class Boek
    {
        #region Constructors voor Boek
        public Boek(string titel, string beschrijving)
        {
            Titel = titel;
            Beschrijving = beschrijving;
        }

        public Boek(string titel, string beschrijving, Uitgeverij uitgeverij, List<Auteur> auteurs) : this(titel, beschrijving)
        {
            Uitgeverij = uitgeverij;
            Auteurs = auteurs;
        }
        #endregion

        #region Properties voor Boek
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public Uitgeverij Uitgeverij { get; set; }
        public List<Auteur> Auteurs { get; set; } = new List<Auteur>();
        #endregion
    }
}
