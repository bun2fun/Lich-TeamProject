u*/sing System;****************/

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichtOut
{
    class Game
    {
        //create matrix of tiles
        //print buttons depending on mode
        //method to check if all lights are off

        public bool AllLightsAreOff(LightTile[,] tiles)
        {
            for (int row = 0; row < tiles.GetLength(0); row++)
            {
                for (int col = 0; col < tiles.GetLength(1); col++)
                {
                   if (tiles[row, col].On)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}