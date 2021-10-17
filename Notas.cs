using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    public class Notas
    {
        public double getNota()
        {
            double nota;
            Console.WriteLine("### Digite a nota:    ###");
            nota = Convert.ToDouble(Console.ReadLine());

            while (nota < 0 || nota > 10)
            {
                Console.WriteLine("### A nota deve estar ente 0 e 10!!    ###");
                Console.WriteLine("### Digite a nota:    ###");
                nota = Convert.ToDouble(Console.ReadLine());
            }

            return nota;
        }

        public double getMedia(double nota1, double nota2, double nota3)
        {
            double media;
            media = (nota1 + nota2 + nota3) / 3;
            media = Math.Round(media, 1);

            return media;
        }

        public void getApRep(double media)
        {
            if(media >= 7.0)
            {
                Console.WriteLine("### Aluno aprovado com média de {0}. Parabéns!    ###", media);
            } else 
            {
                Console.WriteLine("### O aluno não passou direto. Precisa de Prova Final.    ###");
                Notas provaFinal = new Notas();

                double nota4;
                double mediaFinal;
                nota4 = Convert.ToDouble(provaFinal.getNota());

                mediaFinal = (media + nota4) / 2;
                mediaFinal = Math.Round(mediaFinal, 1);

                if (mediaFinal > 5)
                {               
                    Console.WriteLine("### Aluno aprovado com Prova Final    ###\n### Sua média foi {0}    ###", mediaFinal);
                } else
                {
                    Console.WriteLine("### O aluno está reprovado com média final de {0}    ###", mediaFinal);
                }
            }
        }
    }
}
