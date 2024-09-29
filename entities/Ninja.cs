using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.entities
{
    public class Ninja : Heroi
    {
        public Ninja(string nome, int idade, string tipo): base(nome, idade, tipo) { }
        
        public override string atacar()
        {
            return "usando shuriken";
        }

        public override string defender()
        {
            return "usando bloqueio";
        }
    }
}