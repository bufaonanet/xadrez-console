using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));
                
                
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 4));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 4));



                Tela.ImprimeTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
