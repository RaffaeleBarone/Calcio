using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    public abstract class Giocatore
    {
        public string Nome {  get; set; }
        public string Posizione { get; set; }
        public abstract void Gioca();
    }
}
