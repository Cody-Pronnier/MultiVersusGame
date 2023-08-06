using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiVersusGame.utils
{
    class GridNavigation
    {
        private string[,] options;
        private int row;
        private int col;


        public GridNavigation(string[,] options)
        {
            this.options = options;
            row = 0;
            col = 0;
        }

        public string DisplayGrid()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            while (true)
            {
                // Repositionner le curseur au début de la grille
                Console.SetCursorPosition(0, Console.CursorTop - options.GetLength(0));

                for (int i = 0; i < options.GetLength(0); i++)
                {
                    for (int j = 0; j < options.GetLength(1); j++)
                    {
                        if (i == row && j == col)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(options[i, j].PadRight(15));
                    }
                    Console.WriteLine();
                }

                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow)
                {
                    row = Math.Max(0, row - 1);
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    row = Math.Min(options.GetLength(0) - 1, row + 1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    col = Math.Max(0, col - 1);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    col = Math.Min(options.GetLength(1) - 1, col + 1);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return options[row, col];
                    
                }
            }
        }
    }
}
