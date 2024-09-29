using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.entities
{
    public class Guerreiro : Heroi
    {
        public Guerreiro(string nome, int idade, string tipo): base(nome, idade, tipo) { }
        
        public override string atacar()
        {
            return "usando espada";
        }

        public override string defender()
        {
            return "usando escudo";
        }
    }

}