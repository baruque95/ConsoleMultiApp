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
        public int[] contador = new int[3];

        public Pets()
        {
            string nome = setNome();
            int[] tipo = setTipo(contador);
        }

        public string setNome()
        {
            string nome;
            Console.WriteLine("### Digite o nome do seu pet:                     ###");
            nome = Console.ReadLine();

            return nome;
        }

        public int[] setTipo(int[] contador)
        {
            int tipo;
            Console.WriteLine("###           Digite o tipo do seu pet:           ###");
            Console.WriteLine("### (1) Cachorro;                                 ###");
            Console.WriteLine("### (2) Gato;                                     ###");
            Console.WriteLine("### (3) Peixe;                                    ###");
            Console.WriteLine("###  Obs: Opções diferentes serão consideradas 3  ###");

            tipo = Convert.ToInt32(Console.ReadLine());

            if(tipo == 1)
            {
                contador[0]++;
            } else if (tipo == 2) {
                contador[1]++;
            } else
            {
                contador[2]++;
            }

            return contador;
        }

        public void imprimeQtd()
        {
            int i;
            int cachorros = 0, gatos = 0, peixes = 0;
            for (i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    cachorros = contador[i];
                } else if (i == 1)
                {
                    gatos = contador[i];
                } else
                {
                    peixes = contador[i];
                }
            }

            Console.WriteLine("Foram registrados {0} cachorros, {1} gatos e {2} peixes.", cachorros, gatos, peixes);

        }   
    }
}

/*
       public int[] contaPet()
       {
           int i;
           int[] contador = new int[5];

           for (i = 0; i < 5; i++)
           {
               if (tipo == 1)
               {
                   contador[i] = 1;
               }
               else if (tipo == 2)
               {
                   contador[i] = 2;
               }
               else
               {
                   contador[i] = 3;
               }
           }
           return contador;
       }

       public void imprimeTipos(int[] contador)
       {
           int i, j;
           int cachorros = 0;
           int gatos = 0;
           int peixes = 0;

           for (i = 0; i < 6; i++)
           {
               if(contador[i] == 1)
               {
                   cachorros++;
               } else if (contador[i] == 2)
               {
                   gatos++;
               } else
               {
                   peixes++;
               }
           }

           Console.WriteLine("Foram cadastrados {0} cachorros, {1} gatos e {2} peixes.", cachorros, gatos, peixes);
       */
