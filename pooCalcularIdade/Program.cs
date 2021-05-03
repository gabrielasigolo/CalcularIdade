using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalcularIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa");
            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine()); // converte o dado recebido em inteiro pois o ReadLine pega valor em string 
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
