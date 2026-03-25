﻿namespace RoboTupiniquim.ConsoleApp;

using System;

static class Robot
{
    public static int RobotX = 2;
    public static int RobotY = 1;
    public static char Orientation = 'N';

    public static void Config(int PositionX, int PositionY, char Orient)
    {
        RobotX = PositionX;
        RobotY = PositionY;
        Orientation = Orient;
    }

    public static void RunCommand(char[,] Grid, string Command)
    {
        for (int i = 0; i < Command.Length; i++)
        {
            Console.WriteLine("Pressione ENTER para avançar...");
            Console.ReadLine();
            char c = Command[i];

            if (c == 'E')
            {
                Robot.TurnLeft();
            }
            else if (c == 'D')
            {
                Robot.TurnRight();
            }
            else if (c == 'M')
            {
                Grid[RobotX, RobotY] = '.';
                Robot.Move();
                Grid[RobotX, RobotY] = 'R';
            }

            Program.ShowGrid(Grid, RobotX, RobotY, Orientation);
        }
    }

    public static void Move()
    {
        if (Orientation == 'N')
            RobotX++;
        else if (Orientation == 'S')
            RobotX--;
        else if (Orientation == 'L')
            RobotY++;
        else if (Orientation == 'O')
            RobotY--;
    }

    public static void TurnLeft()
    {
        if (Orientation == 'N') Orientation = 'O';
        else if (Orientation == 'O') Orientation = 'S';
        else if (Orientation == 'S') Orientation = 'L';
        else Orientation = 'N';
    }

    public static void TurnRight()
    {
        if (Orientation == 'N') Orientation = 'L';
        else if (Orientation == 'L') Orientation = 'S';
        else if (Orientation == 'S') Orientation = 'O';
        else Orientation = 'N';
    }
}

class Program
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

        Robot.Config(2, 1, 'N');
        Grid[Robot.RobotX, Robot.RobotY] = 'R';

        string Command = "EMEMEMEMM";

        ShowGrid(Grid, Robot.RobotX, Robot.RobotY, Robot.Orientation);
        Console.WriteLine($"Posição inicial do Robô Tupiniquim: {Robot.RobotY} {Robot.RobotX} {Robot.Orientation}");

        Robot.RunCommand(Grid, Command);

        Console.WriteLine($"Posição final do Robô Tupiniquim: {Robot.RobotY} {Robot.RobotX} {Robot.Orientation}");
    }

    public static void ShowGrid(char[,] Grid, int RobotX, int RobotY, char Orientation)
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