namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] path;

        public int Length => this.path.Length;

        public Path(MapLocation[] path) => this.path = path;

        public MapLocation GetLocationAt(int pathStep) => (pathStep < path.Length) ? this.path[pathStep] : null;

        public bool OnPath(Path path, Point point)
        {
            return point.X >= 0 && point.X < path.Length &&
                   point.Y >= 0 && point.Y < path.Length;
        }
    }
}