using System;
using System.Linq;

namespace OOPussel
{
    class NPuzzle : BoardGame
    {
        private readonly Random rnd = new Random();

        public NPuzzle(int boardLength = 0)
                 : base(boardLength)
        {            
            ShuffleGameBoard();
        }
        public void ShuffleGameBoard()
            {
                for (int i = 0; i < BoardSize * 4; i++)
                {
                    int ranIndex1 = rnd.Next(0, BoardSize - 2);
                    int ranIndex2 = rnd.Next(0, BoardSize - 2);
                    while (ranIndex1 == ranIndex2)
                    {
                        ranIndex2 = rnd.Next(0, BoardSize - 2);
                    }
                    int temp = Gameboard[ranIndex1];
                    this.Gameboard[ranIndex1] = Gameboard[ranIndex2];
                    this.Gameboard[ranIndex2] = temp;
                }
            }
        public void PrintGameboard()
        {
            int index = 0;
            for (int x = 0; x < BoardLength; x++)
            {
                for (int y = 0; y < BoardLength; y++)
                {
                    if (Gameboard[index] == BoardSize)
                    {
                        Console.Write("[  ]");
                    }
                    else if (Gameboard[index] < 10)
                    {
                        Console.Write("[0" + Gameboard[index] + "]");
                    }
                    else
                    {
                        Console.Write("[" + Gameboard[index] + "]");
                    }
                    index++;
                }
                Console.WriteLine();
            }
        }
        public bool IsSolved()
        {
            BoardGame solved = new BoardGame(BoardLength, BoardWidth);
            if (Gameboard.SequenceEqual(solved.Gameboard))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}