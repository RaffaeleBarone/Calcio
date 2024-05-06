using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    public class Squadra<T> where T : Giocatore
    {
        private List<T> giocatori = new List<T>();

        public void Aggiungi(T giocatore)
        {
            giocatori.Add(giocatore);
        }

        public void Rimuovi(T giocatore)
        {
            giocatori.Remove(giocatore);
        }

        public IEnumerable<T> GiocatoriPosizione(string posizione)
        {
            return giocatori.Where(g => g.Posizione == posizione);
        }

        public IEnumerable<T> Filtro(Func<T, bool> func)
        {
            return giocatori.Where(func).ToList();
        }

        public delegate bool FiltroGiocatore(T giocatore);
    }
}
