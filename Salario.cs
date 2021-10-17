using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class Salario
    {
        public double getSalario()
        {
            double salario;
            Console.WriteLine("Digite o seu salário: \n");
            salario = Convert.ToDouble(Console.ReadLine());

            return salario;
        }

        public double getSalarioMinimo()
        {
            double salarioMinimo;
            Console.WriteLine("Digite o valor do salário mínimo atual: \n");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            return salarioMinimo;
        }

        public void getMinimos(double salario, double salarioMinimo)
        {
            double minimos;
            minimos = salario / salarioMinimo;

            Console.WriteLine("Você ganha {0} salários mínimos.", minimos);
        }
    }
}
