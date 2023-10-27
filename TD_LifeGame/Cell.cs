namespace TD_LifeGame
{
    public class Cell
    {
        bool _isAlive;
        bool _nextState;

        public bool IsAlive
        {
            get => _isAlive;
            set => _isAlive = value;
        }

        public bool NextState
        {
            get => _nextState;
            set => _nextState = value;
        }

        public Cell(bool state) { IsAlive = state; }

        public void ComeAlive() { NextState = true; }
        
        public void PassAway() { NextState = false; }

        public void Update() { IsAlive = NextState; }
    }
}