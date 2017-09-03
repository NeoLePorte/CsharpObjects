using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundries of the map.");
            }
        }
        public bool InRangeOf(MapLocation location, int range) => DistanceTo(location) <= range;
    }
}