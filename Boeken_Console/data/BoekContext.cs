using Boeken_Console.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.data
{
    public class BoekContext : DbContext
    {
        // in deze klasse geven we aan welke objecten/tabellen we gebruiken door middel van DbSets. 
        #region Het gebruik van DbSet om met EF datatabellen te creëren.
        public DbSet<Boek> Boeken { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }
        #endregion

        //instellen  met  welke databank  we  gaan  werken
        #region Een methode om aan te geven welke database dit project gebruikt.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-698J12G;Initial Catalog=boekDB;Integrated Security=True");
        }
        #endregion
    }
}
