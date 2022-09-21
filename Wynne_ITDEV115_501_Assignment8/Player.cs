namespace TicTacToeInheritance
{
    abstract class Player {
        private string pieces = " ";
        public string Pieces { get { return pieces; } set { pieces = value; } }
        public Player(string s) { Pieces = s; }
        public abstract int MakeMove(string[] currentBoard);
    }
}
