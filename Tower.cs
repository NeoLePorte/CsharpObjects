using System;
namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;


        private MapLocation mapLocation;

        public Tower(MapLocation mapLocation)
        {
            this.mapLocation = mapLocation;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _accuracy;
        }

        public Tower(MapLocation location, Map map)
        {
            _location = location;

            if(!map.OnMap(_location))
            {
                throw new OutOfBoundsException("Towers cannot be placed on paths");
            }
            
        }


        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && invader._location.InRangeOf(invader._location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader.");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Blew that dude up!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed invader.");
                    }
                    break;
                }
            }
        } 

    }
}
