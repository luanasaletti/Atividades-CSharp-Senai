using System;

namespace JogoRPG
{
    public class Monstro : Entidade
    {
        public string Tipo { get; set; }

        public Monstro(string nome, string tipo, int pontosDeVida, int ataque)
            : base(nome, pontosDeVida, ataque)
        {
            Tipo = tipo;
        }

        // Polimorfismo: comportamento diferente ao receber dano
        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano);
            Console.WriteLine($"O monstro {Nome} do tipo {Tipo} ruge de dor!");
        }
    }
}
