﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcio
{
    public class Difensore : Giocatore
    {
        public override void Gioca()
        {
            Console.WriteLine("Il difensore difende");
        }
    }
}
