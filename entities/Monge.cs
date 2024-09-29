using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.entities
{
    public class Monge : Heroi
    { 
        public Monge(string nome, int idade, string tipo): base(nome, idade, tipo) { }
        
        public override string atacar()
        {
            return "usando artes marciais";
        }

        public override string defender()
        {
            return "usando esquiva";
        }
    }
}