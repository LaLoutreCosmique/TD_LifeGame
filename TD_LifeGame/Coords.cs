namespace TD_LifeGame
{
    public readonly struct Coords
    {
        public readonly int X;
        public readonly int Y;

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X : {X}, Y : {Y}";
        }
    }
}