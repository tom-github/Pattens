using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class BaseDeDadosQuimica
    {
        // Base de Dados da 'API legada'
        public float getPontoCritico(string composto, string point)
        {
            float temperatura = 0.0F;
            // Ponto de Ebulição
            if (point == "E")
            {
                switch (composto.ToLower())
                {
                    case "água": temperatura = 0.0F; break;
                    case "benzina": temperatura = 5.5F; break;
                    case "álcool": temperatura = -114.1F; break;
                }
            }
            // Ponto de Fusão
            else
            {
                switch (composto.ToLower())
                {
                    case "água": temperatura = 100.0F; break;
                    case "benzina": temperatura = 80.1F; break;
                    case "álcool": temperatura = 78.3F; break;
                }
            }
            return temperatura;
        }
        public string getEstruturaMolecular(string composto)
        {
            string estrutura = "";
            switch (composto.ToLower())
            {
                case "água": estrutura = "H20"; break;
                case "benzina": estrutura = "C6H6"; break;
                case "álcool": estrutura = "C2H6O2"; break;
            }
            return estrutura;
        }
        public double getPesoMolecular(string composto)
        {
            double peso = 0.0;
            switch (composto.ToLower())
            {
                case "água": peso = 18.015; break;
                case "benzina": peso = 78.1134; break;
                case "álcool": peso = 46.0688; break;
            }
            return peso;
        }
    }
}
