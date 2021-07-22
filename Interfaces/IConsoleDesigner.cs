﻿namespace MinefieldApp.Interfaces
{
    public interface IConsoleDesigner
    {
        void ShowGrid(ITile[,] tiles, ITile currentTile, ITile finishTile);
        void ShowProximity(int distance);
    }
}
