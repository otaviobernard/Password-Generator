using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoSenha;
            Password senha = new Password();
            Console.WriteLine("Informe o tamanho da senha");
            tamanhoSenha = int.Parse(Console.ReadLine());
            senha.Senha = senha.passwordGenerator(tamanhoSenha);
            Console.WriteLine(senha.Senha);
        }
    }
}
