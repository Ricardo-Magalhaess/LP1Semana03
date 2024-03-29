﻿using System;

namespace RPS
{
    
    enum GameItem
    {
        
        Fly = 1 << 0,
        Invisibility = 1 << 1,
        Clone = 1 << 2,
        DoubleJump = 1 << 3
    }
    class Program
    {
        private static void Main(string[] args)
        {
            int resultado = RockPaperScissors(args[0], args[1]);
            switch (resultado)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            int Value = 0;
            if (player1 == player2)
            {
                Value = 0; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                Value = 1; // Player 1 wins
            }
            else
            {
                Value = 2; // Player 2 wins
            }
            return Value;
        }
    }
}
