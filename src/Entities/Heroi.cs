using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_mentoria.src.Entities
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int PontosVida { get; set; }
        public int PontosMagia { get; set; }
        public string ClasseFantastica { get; set; }
        public int ValorUltimoAtaque { get; set; }

        //construtor
        public Heroi(string Nome, string ClasseFantastica){
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosVida = 50;
            this.PontosMagia = 50;
        }

        //metodo atacar
        public virtual string Atacar(){
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1, 20);
            this.ValorUltimoAtaque = forcaAtaque;
            
            return this.Nome + " ataca com sua espada e dá "
                + forcaAtaque + " de dano.";
        }

        //metodo para receber dano
        public void ReceberDano(int danoRecebido){
            this.PontosVida -= danoRecebido;
        }

        public override string ToString()
        {
            return "Meu nome é " + this.Nome + "\n" 
                + "Nível: " + this.Nivel + "\n" 
                + "Ponto de vida: " + this.PontosVida + "\n"
                + "Ponto de magia: " + this.PontosMagia + "\n";
        }
    }
}