using System;

namespace BattleshipTDD.Game
{
    public class Board
    {
        public object Size { get; set; }

        public Board(string boardSize)
        {
            Size = boardSize;
        }
        
    }
}
