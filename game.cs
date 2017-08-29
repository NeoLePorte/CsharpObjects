using System;

namespace TreehouseDefense
{
    class Game
    {
           static void Main()
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);


            Console.WriteLine(point.DistanceTo(5, 5));
        }
    }
}