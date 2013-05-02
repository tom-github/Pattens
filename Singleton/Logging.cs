using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Singleton
{
    public class Logging
    {
        // instancia estática do próprio Objeto
        static Logging instancia = null;

        // outro atributo qualquer da classe
        public ArrayList registros = new ArrayList();

        // construtor privado previne a
        // não instanciação da classe

        private Logging()
        {
        }

        public static Logging Instancia
        {
            get
            {
                //instancia a classe caso nao tenha sido
                if (instancia == null)
                {
                    instancia = new Logging();
                }
                //retorna o objeto unitário
                return instancia;
            }
        }

        // outro método qualquer da classe
        public void mostraRegistros()
        {
            Console.WriteLine(" Registros Gravados\n");
            foreach (String registro in registros)
            {
                Console.WriteLine(" " + registro + "\n");
            }
        }
    }
}
