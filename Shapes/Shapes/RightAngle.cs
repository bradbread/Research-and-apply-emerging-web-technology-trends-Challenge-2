using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle(double pSideLength1, double pSideLength2)
        {
            SideLength1 = pSideLength1;
            SideLength2 = pSideLength2;
            SideLength3 = Math.Sqrt((SideLength1 * SideLength1) + (SideLength2 * SideLength2));
        }

        public double GetArea()
        {
            return  (SideLength1 * SideLength2) / 2;
        }

        public double GetPerimeter()
        {
            return SideLength1 + SideLength2 + SideLength3;
        }

        public override double Operation1()
        {
            throw new NotImplementedException();
        }

        public void SetHypotenuse()
        {
            throw new NotImplementedException();
        }

    }
}
