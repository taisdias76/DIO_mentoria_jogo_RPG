using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_mentoria.src.Entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosVida = 80;
            this.PontosMagia = 50;
        }

        public override string Atacar(){
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1, 15);
            this.ValorUltimoAtaque = forcaAtaque;

            return this.Nome + " ataca e dá "
                + forcaAtaque + " de dano.";
        }
    }
}