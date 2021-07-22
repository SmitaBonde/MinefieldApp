﻿namespace MinefieldApp.Interfaces
{
    public interface ITile
    {
        void Activate(IPlayer player);
        int GetXPos();
        int GetYPos();
        string GetXLabel();
        string GetYLabel();
        string GetId();
    }
}
