using System;

namespace Calcio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Squadra<Giocatore> squadra = new Squadra<Giocatore>();
            squadra.Aggiungi(new Attaccante { Nome = "Lautaro Martinez", Posizione = "Attaccante" });
            squadra.Aggiungi(new Centrocampista { Nome = "Hakan Calhanoglu", Posizione = "Centrocampista" });
            squadra.Aggiungi(new Difensore { Nome = "Benjamin Pavard", Posizione = "Difensore" });
            squadra.Aggiungi(new Portiere { Nome = "Yann Sommer", Posizione = "Portiere" });

            Func<Giocatore, bool> filtro = g => g.Posizione == "Attaccante";
            var attaccanti = squadra.Filtro(filtro);

            foreach(var a in attaccanti)
            {
                a.Gioca();
                Console.WriteLine(a.Nome);
            }



        }
    }
}
