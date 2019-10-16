using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(double psideLength1, double psideLength2)
        {
            SideLength1 = psideLength1;
            SideLength2 = psideLength2;
            SideLength3 = psideLength1;
            SideLength4 = psideLength2;
        }

        public override double GetArea()
        {
            return SideLength1 * SideLength2;
        }

        public override double GetPerimeter()
        {
            return SideLength1 + SideLength2 + SideLength3 + SideLength4;
        }

        public override double Operation1()
        {
            throw new NotImplementedException();
        }
    }
}
