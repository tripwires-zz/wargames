using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripwires.Games.Wargames.Lib.Types
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Calculates the distance between this coordinate and the other
        /// </summary>
        /// <param name="c">an other coordinate</param>
        /// <returns>a value that is the difference</returns>
        public int CalculateDistance(Coordinate c)
        {
            int diffX = this.MakePositive(this.X - c.X);
            int diffY = this.MakePositive(this.Y - c.Y);
            //http://www.mathwarehouse.com/geometry/triangles/triangle-formulas.php
            return (int)Math.Floor(Convert.ToDecimal((Math.Sqrt(Math.Pow(diffX,2) + Math.Pow(diffY,2)))));

        }
        private int MakePositive(int value)
        {
            int result = value;
            result = (result < 0) ? -result : result;
            return result;
        }
    }
}
