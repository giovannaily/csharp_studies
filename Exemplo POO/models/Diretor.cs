using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {}
            public override void Apresentar()
            {
            Console.WriteLine($"Diretor {Nome}");
            }
            
        
    }
}