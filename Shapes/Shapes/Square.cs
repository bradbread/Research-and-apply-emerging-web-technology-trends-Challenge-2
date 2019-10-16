using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{

    public class Square : Quadrilateral
    {
        public Square(double psideLength1)
        {
            SideLength1 = psideLength1;
            SideLength2 = psideLength1;
            SideLength3 = psideLength1;
            SideLength4 = psideLength1;
        }

        public override double GetArea()
        {
            return SideLength1 * SideLength1;
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
