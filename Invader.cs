namespace TreehouseDefense
{
    class Invader
    {
        public int Health { get; private set; } = 2;

        private readonly Path _path;

        public bool HasScored => _pathStep >= _path.Length;

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized);

        private int _pathStep = 0;

        public MapLocation _location => _path.GetLocationAt(_pathStep);

        public Invader(Path path) => _path = path;

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor) => Health -= factor;
    }
}