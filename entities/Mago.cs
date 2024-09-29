using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.entities
{
    public class Mago : Heroi
    {
        public Mago(string nome, int idade, string tipo): base(nome, idade, tipo) { }
        
        public override string atacar()
        {
            return "usando magia";
        }

        public override string defender()
        {
            return "usando campo de força";
        }
    }
}