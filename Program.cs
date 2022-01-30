using System;
using POO_mentoria.src.Entities;

namespace POO_mentoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro");
            Inimigo kingMummy = new Inimigo("King Mummy", "Zumbi");

            arus.Atacar();
            kingMummy.Atacar();
            
            Console.WriteLine(arus.Nome + " - força de ataque: " + arus.ValorUltimoAtaque);
            Console.WriteLine(kingMummy.Nome + " - força de ataque: " + kingMummy.ValorUltimoAtaque);

            if(arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque){
                Console.WriteLine("\nEmpate! Ambos deram dano de " + arus.ValorUltimoAtaque);
            }
            else if(arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque){
                kingMummy.ReceberDano(arus.ValorUltimoAtaque - kingMummy.ValorUltimoAtaque);
                Console.WriteLine("\n"+ arus.Nome + " venceu esse round!");
            }else{
                arus.ReceberDano(kingMummy.ValorUltimoAtaque - arus.ValorUltimoAtaque);
                Console.WriteLine("\n"+ kingMummy.Nome + " venceu esse round!");
            }
        }
    }
}
