using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral(double psideLength1)
        {
            SideLength1 = psideLength1;
            SideLength2 = psideLength1;
            SideLength3 = psideLength1;
        }

        public double GetArea()
        {
            return (Math.Sqrt(3) / 4) * (SideLength1 * SideLength1);
        }

        public double GetPerimeter()
        {
            return SideLength1 + SideLength2 + SideLength3;
        }

        public override double Operation1()
        {
            throw new NotImplementedException();
        }
    }
}
