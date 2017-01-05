using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripwires.Games.Wargames.Lib.Types
{
    public class Coordinate
    {
        /// <summary>
        /// X value of a Coordinate
        /// </summary>
        public Decimal X { get; set; }

        /// <summary>
        /// Y value of a Coordinate
        /// </summary>
        public Decimal Y { get; set; }

        /// <summary>
        /// constructor for a coordinate that accepts an x and y value
        /// </summary>
        /// <param name="x">X value of a Coordinate</param>
        /// <param name="y">Y value of a Coordinate</param>
        public Coordinate(Decimal x,Decimal y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Calculates the distance between this coordinate and the other
        /// </summary>
        /// <param name="c">an other coordinate</param>
        /// <returns>a value that is the difference</returns>
        public Decimal CalculateDistance(Coordinate c)
        {
            //since we're going to pow these variables no need to figure out if they are positive or not
            Decimal diffX = this.X - c.X;
            Decimal diffY = this.Y - c.Y;
            //http://www.mathwarehouse.com/geometry/triangles/triangle-formulas.php
            return Math.Floor(Convert.ToDecimal((Math.Sqrt(Math.Pow((int)diffX,2) + Math.Pow((int)diffY,2)))));

        }
    }
}
