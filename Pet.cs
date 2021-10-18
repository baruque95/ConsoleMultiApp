using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMultiApp
{
    class Pet 
    {
        private String nome;
        private String tipo;
        static string[] tipos = {"cachorro", "gato", "peixe"};

        public Pet(String nome, String tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        public string getName()
        {
            return this.nome;            
        }
        
        public void setName(string nome)
        {
            this.nome = nome;
        }

        public string getType()
        {
            return this.tipo;
        }

        public void setType(string tipo)
        {
            if (tipo == "cachorro" || tipo == "gato" || tipo == "peixe")
            {
                this.tipo = tipo;
            } 
        }
    }
}
