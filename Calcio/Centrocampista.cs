using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    public class Centrocampista : Giocatore
    {
        public override void Gioca()
        {
            Console.WriteLine("Il centrocampista passa il pallone");
        }
    }
}
