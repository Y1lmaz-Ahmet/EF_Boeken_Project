using Boeken_Console.data;
using Boeken_Console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken_Console.Manager
{
    public class BoekManager
    {
        private BoekContext ctx = new BoekContext();
        public void VoegBoekToe(Boek boek)
        {
            ctx.Boeken.Add(boek);
            ctx.SaveChanges();
        }
    }
}
