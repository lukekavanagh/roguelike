﻿namespace Roguelike
{
    public class Player
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public string ToString()
        {
            return "?";
        }

    }
}