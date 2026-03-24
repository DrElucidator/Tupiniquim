namespace RoboTupiniquim.ConsoleApp;

using System;

class program
{
    static void Main(string[] arg)
    {
        int GridRows = 5;
        int GridColumns = 5;
        char[,] Grid = new char[GridRows, GridColumns];

        for (int i = 0; i < GridRows; i++)
        {
            for (int z = 0; z < GridColumns; z++)
                Grid[i, z] = '.';
        }
        int RobotX = 2;
        int RobotY = 1;
        char Orientation = 'N';
        Grid[RobotX, RobotY] = 'R';

        string Command = "EMEMEMEMM";

        ShowGrid(Grid, RobotX, RobotY, Orientation);
        Console.WriteLine($"Posição inicial do Robô Tupiniquim: {RobotY} {RobotX} {Orientation}");

        for (int i = 0; i < Command.Length; i++)
        {
            Console.WriteLine("Pressione ENTER para avançar...");
            Console.ReadLine();
            char c = Command[i];

            if (c == 'E')
            {
                if (Orientation == 'N') Orientation = 'O';
                else if (Orientation == 'O') Orientation = 'S';
                else if (Orientation == 'S') Orientation = 'L';
                else Orientation = 'N';
            }
            else if (c == 'D')
            {
                if (Orientation == 'N') Orientation = 'L';
                else if (Orientation == 'L') Orientation = 'S';
                else if (Orientation == 'S') Orientation = 'O';
                else Orientation = 'N';
            }
            else if (c == 'M')
            {
                Grid[RobotX, RobotY] = '.';

                if (Orientation == 'N')
                    RobotX++;
                else if (Orientation == 'S')
                    RobotX--;
                else if (Orientation == 'L')
                    RobotY++;
                else if (Orientation == 'O')
                    RobotY--;

                Grid[RobotX, RobotY] = 'R';
            }
            ShowGrid(Grid, RobotX, RobotY, Orientation);
        }
        Console.WriteLine($"Posição final do Robô Tupiniquim: {RobotY} {RobotX} {Orientation}");
    }
    static void ShowGrid(char[,] Grid, int RobotX, int RobotY, char Orientation)
    {
        Console.Clear();
        for (int i = Grid.GetLength(0) - 1; i >= 0; i--)
        {
            for (int z = 0; z < Grid.GetLength(1); z++)
            {
                Console.Write(Grid[i, z] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Posição atual do Robô Tupiniquim: {RobotY} {RobotX} {Orientation}");
    }
}