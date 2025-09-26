using System;
using System.Collections.Generic;

namespace Template
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Map
    {
        private Dictionary<Point, Soldier> soldiers = new Dictionary<Point, Soldier>();

        public void SetSoldier(Point point, Soldier soldier)
        {
            soldiers[point] = soldier;
        }

        public Soldier GetSoldier(Point point)
        {
            soldiers.TryGetValue(point, out var soldier);
            return soldier;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Display()
        {
            Console.WriteLine($"Map size: {Width} x {Height}");
        }
    }

   
}