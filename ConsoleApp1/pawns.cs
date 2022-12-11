using System;

namespace ConsoleApp1
{
    struct ChessPawnPosition
    {
        public int x;
        public int y;
    }
    struct ChessGridInfo
    {
        public int length;
        public int height;
        public ChessPawn[,] Grid;
        public ChessGridInfo(ChessPawn[,] _Grid)
        {
            Grid= _Grid;
        }
    }
    internal class ChessPawn
    {
        internal char Icon = '!';
        internal ChessPawnPosition Position;
        internal ChessPawn(char _icon, ChessPawnPosition _startingPos) 
        {
            Icon = _icon;
            Position = _startingPos;
        }
        internal virtual void move(int x, int y, int boardLength, int boardHeight)
        {
            
        }
    }
}
