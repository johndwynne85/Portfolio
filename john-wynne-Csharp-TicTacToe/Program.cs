using Wynne_ITDEV115_501_Assignment8;

namespace TicTacToeInheritance
{
    class Program {
        static void Main(string[] args) {
            Game tttGame = new Game();
            Wynne_ITDEV115_501_Assignment8.Info info = new Info();
            info.DisplayInfo("Assignment 8 - Tic Tac Toe Inheritance");
            tttGame.Play();
        }
    }
}
