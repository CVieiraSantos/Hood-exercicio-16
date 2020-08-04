using System;
using System.Collections.Generic;

namespace Hood_exercicio16 {
    class Program {
        static void Main(string[] args) {

            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sexo: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            list.Add(new Pessoa(nome, sexo, idade));
            
            Console.WriteLine();
            
            Pessoa p = new Pessoa(nome, sexo, idade);
            p.AceitarOuNaoAceitar();

        }

    }
}
