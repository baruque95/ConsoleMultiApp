using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class Raio
    {
        public double getRaio()
        {
            double raio;
            Console.WriteLine("Digite o raio da esfera: \n");
            raio = Convert.ToDouble(Console.ReadLine());
            
            while (raio <= 0)
            {
                Console.WriteLine("O valor digitado deve ser maior que 0 (ZERO)");
                Console.WriteLine("Digite o raio da esfera: \n");
                raio = Convert.ToDouble(Console.ReadLine());
            }

            return raio;
        }

        public void getVolume(double raio)
        {
            double volume;
            double raioElevado;
            raioElevado = Math.Pow(raio, 3);

            volume = 4 / (3 * 3.14 * raioElevado);
            // Creio que houve um erro de digitação no exercício e a fórmula
            // do volume da esfera ficou incorreto.
            // Para o volume correto, usar \/
            //volume = (4 * 3.14 * raioElevado) / 3;


            Console.WriteLine("O volume da esfera de raio {0} é de {1}", raio, volume);
        }
    }
}
