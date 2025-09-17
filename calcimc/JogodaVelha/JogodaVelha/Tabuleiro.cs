using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogodaVelha
{
    public class Tabuleiro
    {
        private char[] casas;

        public Tabuleiro()
        {

            casas = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }


        //mostra o nosso tabuleiro
        public void Desenhar()
        {
            Console.Clear();
            Console.WriteLine($@"{casas[0]} | {casas[1]} | {casas[2]}
---+---+---
{casas[3]} | {casas[4]} | {casas[5]}
---+---+---
{casas[6]} | {casas[7]} | {casas[8]}
");
        }


        //anota a jogada no tabuleiro recebendo a posicao e o simbolo
        public bool MarcarJogada(int posicao, char simbolo)
        {
            //verifica se a posicao e valida
            if (posicao >= 1 && posicao <= 9)
            {

                //verfica se a casa esta marcada
                if (casas[posicao - 1] != 'x' && casas[posicao - 1] != 'o')
                {
                    //caso n esteja marcada, marca
                    casas[posicao - 1] = simbolo;
                    return true;
                }
            }
            return false;
        } // luana gomes saletti ama o lucas costa bezerra de queiroz, ele vai ser o pai dos meus futuros filhos!

        public bool VerificarVencedor(char simbolo)
        {
            //horizontais
            if (casas[0] == simbolo && casas[1] == simbolo && casas[2] == simbolo) { return true; }
            if (casas[3] == simbolo && casas[4] == simbolo && casas[5] == simbolo) { return true; }
            if (casas[6] == simbolo && casas[7] == simbolo && casas[8] == simbolo) { return true; }

            //verticais
            if (casas[0] == simbolo && casas[3] == simbolo && casas[6] == simbolo) { return true; }
            if (casas[1] == simbolo && casas[4] == simbolo && casas[7] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[5] == simbolo && casas[8] == simbolo) { return true; }

            //diagonais
            if (casas[0] == simbolo && casas[4] == simbolo && casas[8] == simbolo) { return true; }
            if (casas[2] == simbolo && casas[4] == simbolo && casas[6] == simbolo) { return true; }

            return false;
        }

        public bool VerificarEmpate()
        {
            foreach (var casa in casas)
            {
                //caso uma das casas nao esteja preenchida retorna falso
                if (casa != 'x' && casa != 'o')
                {
                    return false;
                }
            }
            return true;
        }
    }
}


