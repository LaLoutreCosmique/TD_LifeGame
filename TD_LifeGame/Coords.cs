namespace TD_LifeGame
{
    public readonly struct Coords
    {
        readonly int _x;
        readonly int _y;

        public Coords(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"X : {_x}, Y : {_y}";
        }
    }
}