using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class Petshop
    {
        private List<Pet> listaPets = new List<Pet>();

        public void cadastroPets()
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                this.listaPets.Add(cadastroPet());
            }

            contaPets(listaPets);
        }

        private Pet cadastroPet()
        {
            string nome;
            string tipo;

            Console.WriteLine("###           Digite o nome do seu pet.           ###");
            nome = Console.ReadLine();


            Console.WriteLine("###           Digite o tipo do seu pet:           ###");
            Console.WriteLine("###    (1) Cachorro;                              ###");
            Console.WriteLine("###    (2) Gato;                                  ###");
            Console.WriteLine("###    (3) Peixe;                                 ###");
            Console.WriteLine("###  Obs: Opções diferentes serão consideradas 3  ###");

            int typeoption = Convert.ToInt32(Console.ReadLine());

            var petTypes = new Dictionary<int, string>()
            {
                { 1, "cachorro"},
                { 2, "gato"},
                { 3, "peixe"}
            };

            if (typeoption == 1 || typeoption == 2)
            {
                tipo = petTypes[typeoption];
            } else
            {
                tipo = petTypes[3];
            }

            return new Pet(nome, tipo);
        }

        private void contaPets(List<Pet> listaPets)
        {
            int i;
            int contadorDog = 0;
            int contadorCat = 0;
            int contadorFish = 0;

            for (i = 0; i < 5; i++)
            {
                Pet pet = listaPets[i];
                string tipoPet = pet.getType();


                if(tipoPet == "cachorro")
                {
                    contadorDog++;
                } 
                else if(tipoPet == "gato")
                {
                    contadorCat++;
                }
                else
                {
                    contadorFish++;
                }
            }
            Console.WriteLine("Foram cadastrados {0} cachorros, {1} gatos e {2} peixes.", contadorDog, contadorCat, contadorFish);
        }
    }
}
