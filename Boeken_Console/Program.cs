using Boeken_Console.Manager;
using Boeken_Console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------- Add-Migration --------
            //(venster) : VIEW > Other Windows > Package Manager Console.
            //Na het uitvoeren vandeze instructie zal er een nieuwe
            //folder verschijnen in het project met de naam Migrations.
            //In deze folder vind je dan enerzijds de klasse terug met de naam die je aan de Add-Migration
            //als parameter hebt meegegevenen anderzijds ook een klasse die verwijst naar je DbContext
            //klasse met als achtervoegsel Snapshot.  In de eerste klasse vind je een beschrijving in code
            //van je tabellen, de tweede geeft dehuidigetoestand weervan het model
            //en zal bij nieuwe migrations (updates) steeds worden aangepast.
            //Om nu het datamodel effectief aan te maken in de databank geef je het
            //commando Update-Database in het Package Manager Consolevenster.


            //-------- Update-Database --------
            //Om nu het datamodel effectief aan te maken in de databank geef je
            //het commando Update-Database in het Package Manager Consolevenster.


            //-------- testen --------
            Console.WriteLine("welcome!");
            Uitgeverij u1 = new Uitgeverij("Lannoo", "Kasteelstraat 97,8700 Tielt", "Info@Lannoo.be");
            Auteur a1 = new Auteur("Fieke Van Der Gucht", "Fieke@hotmail.be");
            Boek b1 = new Boek("Het froot Vlaams VloekBoek", "hier komt normaal gezien de beschrijving!!!");
            b1.Uitgeverij = u1;
            b1.Auteurs.Add(a1);
            BoekManager BM = new BoekManager();
            BM.VoegBoekToe(b1);
        }
    }
}
