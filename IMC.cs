using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class IMC
    {
        public double getPeso()
        {
            double peso;
            Console.WriteLine("\n Digite o seu peso em kg (separado por vírgula) : ");
            peso = Convert.ToDouble(Console.ReadLine());

            return peso;
        }

        public double getAltura()
        {
            double altura;
            Console.WriteLine("\n Digite a sua altura em Metros (separado por vírgula) : \n");
            altura = Convert.ToDouble(Console.ReadLine());

            return altura;
        }

        public double getIMC(double peso, double altura)
        {
            double imc;
            double alturaPot = Math.Pow(altura, 2);
            imc = peso / alturaPot;

            return imc;
        }

        public void definePeso(double imc)
        {
            if (imc < 20)
            {
                Console.WriteLine("Você está abaixo do peso.");
            } else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Você está no peso ideal.");
            } else
            {
                Console.WriteLine("Você está acima do peso.");
            }
        }
    }
}
