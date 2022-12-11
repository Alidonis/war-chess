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
    enum ChessPieceRank
    {
        Rank0 = '\u2080',
        Rank1 = '\u2081',
        Rank2 = '\u2082',
        Rank3 = '\u2083',
        Rank4 = '\u2084',
        Rank5 = '\u2085',
        Rank6 = '\u2086',
        Rank7 = '\u2087',
        Rank8 = '\u2088',
        Rank9 = '\u2089',

    }
    internal class ChessPawn
    {
        internal char Icon = '!';
        internal char Rank = '\u2080';
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
