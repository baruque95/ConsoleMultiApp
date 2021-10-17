using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class Pets
    {
        private string nome;
        private int tipo;

        public string setNome()
        {
            string nome;

            nome = Console.ReadLine();

            return nome;
        }

        public int setTipo()
        {
            int tipo;

            tipo = Convert.ToInt32(Console.ReadLine());

            return tipo;
        }

        public int[] contaPet(int tipo)
        {
            int[] contador = new int[3];

            if (tipo == 1)
            {
                contador[0]++;
            } else if (tipo == 2)
            {
                contador[1]++;
            } else
            {
                contador[2]++;
            }

            return contador;
        }
    }
}
