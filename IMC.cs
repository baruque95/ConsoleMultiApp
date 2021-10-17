using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class IMCService
    {
        private double getPeso()
        {
            double peso;
            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            return peso;
        }

        private double getAltura()
        {
            double altura;
            Console.WriteLine("Digite a sua altura: ");
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
    }
}
