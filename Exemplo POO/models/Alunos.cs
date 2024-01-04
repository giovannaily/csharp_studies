using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.models
{
    public class Alunos : Pessoa
    {
        public Alunos(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}