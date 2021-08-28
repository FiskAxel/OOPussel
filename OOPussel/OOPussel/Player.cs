using System;

namespace OOPussel
{
    class Player
    { 
        public static void PlayPuzzleGame(NPuzzle nPuzzle)
        {
            while (true)
            {
                nPuzzle.PrintGameboard();
                MoveTiles(nPuzzle.BoardLength, nPuzzle.BoardSize, nPuzzle.Gameboard);

                if (nPuzzle.IsSolved())
                {
                    nPuzzle.PrintGameboard();
                    Console.WriteLine("GOOD JOB!");
                    break;
                }
            }
        }
        public static void MoveTiles(int BoardLength, int BoardSize, int[] Gameboard)
        {
            ConsoleKeyInfo keyboardInput = Console.ReadKey();
            Console.Clear();
            int emptyTileIndex = Array.IndexOf(Gameboard, BoardSize);
            if (keyboardInput.Key == ConsoleKey.UpArrow && emptyTileIndex >= BoardLength)
            {
                Gameboard[emptyTileIndex] = Gameboard[emptyTileIndex - BoardLength];
                Gameboard[emptyTileIndex - BoardLength] = BoardSize;
            }
            else if (keyboardInput.Key == ConsoleKey.DownArrow && emptyTileIndex < (BoardSize - BoardLength))
            {
                Gameboard[emptyTileIndex] = Gameboard[emptyTileIndex + BoardLength];
                Gameboard[emptyTileIndex + BoardLength] = BoardSize;
            }
            else if (keyboardInput.Key == ConsoleKey.LeftArrow && emptyTileIndex % BoardLength != 0)
            {
                Gameboard[emptyTileIndex] = Gameboard[emptyTileIndex - 1];
                Gameboard[emptyTileIndex - 1] = BoardSize;
            }
            else if (keyboardInput.Key == ConsoleKey.RightArrow && (emptyTileIndex + 1) % BoardLength != 0)
            {
                Gameboard[emptyTileIndex] = Gameboard[emptyTileIndex + 1];
                Gameboard[emptyTileIndex + 1] = BoardSize;
            }
        }
        public static bool PlayAgain()
        {
            Console.WriteLine("\nPress \"P\" to play again.");
            ConsoleKeyInfo keyboardInput = Console.ReadKey();
            if (keyboardInput.Key == ConsoleKey.P)
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}