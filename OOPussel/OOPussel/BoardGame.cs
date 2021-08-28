
namespace OOPussel
{
    class BoardGame
    {
        public int BoardLength { get; } = 4;
        public int BoardWidth { get; set; } = 4;
        public int BoardSize { get; set; } = 16;
        public int[] Gameboard { get; set; } = new int[16];

        public BoardGame(int boardLength = 4,
                         int boardWidth = 4)
        {
            this.BoardLength = boardLength;
            this.BoardWidth = boardWidth;
            this.BoardSize = boardLength * boardWidth;
            this.Gameboard = new int[boardLength * boardWidth];
            
            for (int i = 0; i < BoardSize; i++)
            {
                this.Gameboard[i] = i + 1;
            }   
        }

        // SQUARE BOARD
        public BoardGame(int boardLength = 4)
        {
            this.BoardLength = boardLength;
            this.BoardWidth = boardLength;
            this.BoardSize = boardLength * boardLength;
            this.Gameboard = new int[boardLength * boardLength];

            for (int i = 0; i < BoardSize; i++)
            {
                this.Gameboard[i] = i + 1;
            }
        }
    }
}