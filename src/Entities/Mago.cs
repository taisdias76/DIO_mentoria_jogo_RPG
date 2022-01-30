using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_mentoria.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosVida = 50;
            this.PontosMagia = 60;
        }
        
        public override string Atacar(){
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1, 10);
            this.ValorUltimoAtaque = forcaAtaque;
            
            return this.Nome + " ataca com seu cajado e dá "
                + forcaAtaque + " de dano.";
        }

        public string Atacar(int bonus){
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1, 10) + bonus;
        
            return this.Nome + " ataca com bônus com seu cajado e dá "
                + forcaAtaque + " de dano.";
        }
        
    }
}