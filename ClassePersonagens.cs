using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class ClassePersonagens
    {
        //variaeis (atributos)
        public string nome;
        public string raca;
        public int poder;

        //funcoes (metodos)
        public void mostra()
        {
            Console.WriteLine($"Seu personagem é {raca} o nome é {nome} com {poder} de poder");
        }
    }
}
