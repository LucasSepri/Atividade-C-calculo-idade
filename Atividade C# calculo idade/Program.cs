using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            int dia;
            int mes;
            int mesHoje;
            int ano;
            int resultado;


            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade atual: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o dia do seu nacimento: ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ano atual: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês atual: ");
            mesHoje = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês do seu nacimento: ");
            mes = int.Parse(Console.ReadLine());

            resultado = ano - idade;

            if (mesHoje < mes)
            {
                Console.WriteLine("Você fará " + idade + " anos.");
            }

            Console.Write(nome + " você naceu no ano de: " + resultado +" no mês: " + mes + " e no dia: " + dia);
           


            Console.ReadKey();
        }
    }
}
