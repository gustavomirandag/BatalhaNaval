using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialização
            const int n = 5; //Tamanho da Matriz
            const int qtdBarcos = 3; //Quantidade de Barcos por Jogador
            const int qtdJogadas = 10; //Total de Jogadas
            char[,] matrizPlayer1 = new char[n, n];
            char[,] matrizPlayer2 = new char[n, n];

            //##### PREENCHE OS BARCOS NAS MATRIZES ######
            //Preenche a Matriz Player 1
            for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Digite para player 1 a linha do barco " + barco);
                int linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite para player 1 a coluna do barco " + barco);
                int coluna = int.Parse(Console.ReadLine());
                matrizPlayer1[linha, coluna] = 'B';
            }

            //Preenche a Matriz Player 2
            for (int barco = 0; barco < qtdBarcos; barco++)
            {
                Console.WriteLine("Digite para player 2 a linha do barco " + barco);
                int linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite para player 2 a coluna do barco " + barco);
                int coluna = int.Parse(Console.ReadLine());
                matrizPlayer2[linha, coluna] = 'B';
            }
            //##############################################

            //######### COMEÇA O JOGO #########
            int player = 1; //Player 1 sempre começa a atacar
            int pontosPlayer1 = 0;
            int pontosPlayer2 = 0;
            for (int jogada = 0; jogada < qtdJogadas; jogada++)
            {
                Console.WriteLine("Player " + player + " digite a linha que deseja atacar");
                int linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Player " + player + " digite a coluna que deseja atacar");
                int coluna = int.Parse(Console.ReadLine());

                //Verifica se acertou um BARCO
                if (player == 1 && matrizPlayer2[linha, coluna] == 'B')
                {
                    pontosPlayer1++; //Incrementa pontuação do Player 1
                    matrizPlayer2[linha, coluna] = ' '; //Transforma B em água
                    Console.WriteLine("Player 1 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosPlayer1);
                }
                if (player == 2 && matrizPlayer1[linha, coluna] == 'B')
                {
                    pontosPlayer2++;
                    matrizPlayer1[linha, coluna] = ' '; //Transforma B em água
                    Console.WriteLine("Player 2 ACERTOU UM BARCO!");
                    Console.WriteLine("Pontuação = " + pontosPlayer2);
                }

                //Alterna o Jogador Atual
                if (player == 1)
                    player = 2;
                else
                    player = 1;
            }
            //#########################################


            //####### VERIFICA O GANHADOR #######
            if (pontosPlayer1 > pontosPlayer2)
                Console.WriteLine("PLAYER 1 GANHOU!");
            else if (pontosPlayer2 > pontosPlayer1)
                Console.WriteLine("PLAYER 2 GANHOU!");
            else
                Console.WriteLine("EMPATARAM!");
            //###################################

            Console.ReadLine();
        }
    }
}
