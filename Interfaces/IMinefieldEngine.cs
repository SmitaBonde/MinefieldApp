namespace MinefieldApp.Interfaces
{
    public interface IMinefieldEngine
    {
        void Start(IBoard board, IPlayer player);

        void End();
    }
}
