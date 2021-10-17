using System;

namespace ConsoleMultiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("##########################");
            Console.WriteLine("# BEM-VINDX AO MULTI APP #");
            Console.WriteLine("# Escolha uma função:    #\n");
            Console.WriteLine("# (1) Cálculo do IMC;    #\n");
            Console.WriteLine("# (2) Salários mínimos;  #\n");
            Console.WriteLine("# (3) Volume da esfera;  #\n");
            Console.WriteLine("# (4) Média dos alunos;  #\n");
            Console.WriteLine("# (5) Pets;              #\n");
            Console.WriteLine("# (6) Encerrar programa; #\n");

            opcao = Convert.ToInt32(Console.ReadLine());

            

            // Programa quebra feio se coloca letra no input de opção!

            if (opcao > 0 && opcao < 7)
            {
                switch (opcao)
                {
                    case 1:
                        // IMC 
                        
                        break;
                    case 2:
                        // SALARIO
                        Console.WriteLine("Salários mínimos");
                        break;
                    case 3:
                        // VOLUME ESFERA
                        Console.WriteLine("Volume da esfera");
                        break;
                    case 4:
                        // MEDIA ALUNOS
                        Console.WriteLine("Calculo da média");
                        break;
                    case 5:
                        // PETS
                        Console.WriteLine("Cadastro de Pets");
                        break;
                    case 6:
                        // ENCERRAR
                        Console.WriteLine("Programa encerrado");
                        break;
                }
            } else
            {
                Console.WriteLine("Comando inválido.");
            }
        }
    }
}
