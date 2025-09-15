using System;

namespace JogoRPG
{
    public class Personagem : Entidade
    {
        public string Classe { get; set; }

        public Personagem(string nome, string classe, int pontosDeVida, int ataque)
            : base(nome, pontosDeVida, ataque)
        {
            Classe = classe;
        }

        public void Curar()
        {
            int cura = 10;
            PontosDeVida += cura;
            Console.WriteLine($"{Nome} usou cura e recuperou {cura} de vida! Vida atual: {PontosDeVida}");
        }
    }
}