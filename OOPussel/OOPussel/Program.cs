using System;

namespace OOPussel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            

            Console.WriteLine("WELCOME TO OOPUSSLE!");
            do
            {
                NPuzzle game = new NPuzzle(SetSize());
                Player.PlayPuzzleGame(game);
            } while (Player.PlayAgain());


            static int SetSize()
            {
                int size = 4;
                Console.WriteLine("Press \"3\" or \"4\" to set the boardsize\nto (3x3) or (4x4)");
                ConsoleKeyInfo keyboardInput;
                do
                {
                    keyboardInput = Console.ReadKey();
                    if (keyboardInput.Key == ConsoleKey.D3)
                    {
                        size = 3;
                    }
                    else if (keyboardInput.Key == ConsoleKey.D4)
                    {
                        size = 4;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT.\n PRESS \"3\" or \"4\"");
                    }
                } while (keyboardInput.Key != ConsoleKey.D3 &&
                            keyboardInput.Key != ConsoleKey.D4);

                Console.Clear();
                return size;
            }
        }       
    }
}