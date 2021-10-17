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
                        double peso;
                        double altura;
                        double imcTotal;

                        IMC imc = new IMC();
                        peso = imc.getPeso();
                        altura = imc.getAltura();
                        imcTotal = imc.getIMC(peso, altura);
                        imc.definePeso(imcTotal);

                        break;
                    case 2:
                        // SALARIO
                        double salario;
                        double salarioMinimo;
                        double minimos;

                        Salario minimo = new Salario();

                        salario = minimo.getSalario();
                        salarioMinimo = minimo.getSalarioMinimo();
                        minimo.getMinimos(salario, salarioMinimo);
                        break;
                    case 3:
                        // VOLUME ESFERA

                        double raio;
                        double volume;

                        Raio calcVolume = new Raio();

                        raio = Convert.ToDouble(calcVolume.getRaio());
                        calcVolume.getVolume(raio);
                        break;
                    case 4:
                        // MEDIA ALUNOS
                        double nota1;
                        double nota2;
                        double nota3;
                        double media;

                        Notas nota = new Notas();

                        nota1 = nota.getNota();
                        nota2 = nota.getNota();
                        nota3 = nota.getNota();
                        media = nota.getMedia(nota1, nota2, nota3);

                        nota.getApRep(media);
                        
                        break;
                    case 5:
                        // PETS
                        int i;
                        Pets pets = new Pets();

                        for (i = 0; i < 6; i++)
                        {
                            string nome = pets.
                        }

                        





                        break;
                    case 6:
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
