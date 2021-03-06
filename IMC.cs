using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class IMC
    {
        private double getPeso()
        {
            double peso;
            Console.WriteLine("\n Digite o seu peso em kg (separado por vírgula) : ");
            Console.WriteLine("\n (Valor mínimo = 30,0 kg!)");
            peso = Convert.ToDouble(Console.ReadLine());

            while (peso <= 30) 
            {
                Console.WriteLine("\n## {0} é um valor INVÁLIDO. Tente novamente: ##", peso);
                Console.WriteLine("\nDigite o seu peso em kg (separado por vírgula) : ");
                Console.WriteLine("\n(Valor mínimo = 30,0 kg!)");
                peso = Convert.ToDouble(Console.ReadLine());
            }           
            return peso;
        }

        private double getAltura()
        {
            double altura;
            Console.WriteLine("\n Digite a sua altura em Metros (separado por vírgula) : \n");
            altura = Convert.ToDouble(Console.ReadLine());

            return altura;
        }

        public double getIMC()
        {

            double peso;
            double altura;
            double imcTotal;

            peso = this.getPeso();
            altura = this.getAltura();
            double alturaPot = Math.Pow(altura, 2);
            imcTotal = peso / alturaPot;
            Console.WriteLine("O seu IMC é de {0}", imcTotal);

            definePeso(imcTotal);            

            return imcTotal;
        }

        private void definePeso(double imc)
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
