using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public void SetNome(string valor)
        {
            nome = valor;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetIdade(int valor)
        {
            if (valor > 0)
            {
                idade = valor;
            }
            else
            {
                Console.WriteLine("Idade invalida, insira uma idade maior que 0");
            }
        }

        public int GetIdade()
        {
            return idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
        }
    }
}
