﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria os postos de gasolina
            PostoDeGasolina p1 = new PostoDeGasolina("Posto do Papai");
            PostoDeGasolina p2 = new PostoDeGasolina("Posto da Mamãe");
            // Cria a distribuidora e anexa os postos a ela
            Distribuidora petrobras = new Distribuidora("Petrobrás", 2.15);
            petrobras.anexar(p1);
            petrobras.anexar(p2);
            // Muda o preco da distribuidora que notifica os postos
            petrobras.PrecoLitroGasolina = 2.18;
            petrobras.PrecoLitroGasolina = 2.22;
            petrobras.PrecoLitroGasolina = 2.25;
            petrobras.PrecoLitroGasolina = 2.28;
        }
    }
}
