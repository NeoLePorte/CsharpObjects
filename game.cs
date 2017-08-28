namespace TreehouseDefense
{
    class Game
    {
           static void Main()
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);

            point = new Point(8, 5);
            isOnMap = map.OnMap(point);
        }
    }
}