using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.entities
{
    public abstract class Heroi
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private string Tipo { get; set; }

        public Heroi(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
        }

        public abstract string atacar();
        public abstract string defender();

    }
}