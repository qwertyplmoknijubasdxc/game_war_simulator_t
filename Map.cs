using System;
using System.Collections.Generic;

namespace GameWarSimulator
{
    /// <summary>
    /// Represents a coordinate point on the map.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Gets the X-coordinate.
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Gets the Y-coordinate.
        /// </summary>
        public int Y { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> struct at the specified coordinates.
        /// </summary>
        /// <param name="x">The X-coordinate.</param>
        /// <param name="y">The Y-coordinate.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    /// <summary>
    /// Represents a 2D map grid that can hold soldiers at specific points.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Stores soldiers by their map position.
        /// </summary>
        private Dictionary<Point, Soldier> soldiers = new Dictionary<Point, Soldier>();

        /// <summary>
        /// Places or replaces a soldier at the specified point.
        /// </summary>
        /// <param name="point">The map coordinate.</param>
        /// <param name="soldier">The soldier to place.</param>
        public void SetSoldier(Point point, Soldier soldier)
        {
            soldiers[point] = soldier;
        }

        /// <summary>
        /// Retrieves the soldier at the specified point, or null if none exists.
        /// </summary>
        /// <param name="point">The map coordinate.</param>
        /// <returns>The soldier at the point, or null.</returns>
        public Soldier GetSoldier(Point point)
        {
            soldiers.TryGetValue(point, out var soldier);
            return soldier;
        }

        /// <summary>
        /// Gets or sets the width of the map.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets the height of the map.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class with the given dimensions.
        /// </summary>
        /// <param name="width">The width of the map.</param>
        /// <param name="height">The height of the map.</param>
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Prints the map size to the console.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Map size: {Width} x {Height}");
        }
    }
}