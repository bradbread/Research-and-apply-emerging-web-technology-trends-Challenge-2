using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape, IShapeCalc
    {
        const double PI = 3.14;
        public double Radius { get; set; }

        public double GetArea()
        {
            return PI * (Radius * Radius);
        }

        public double GetPerimeter()
        {
            return 2 * PI * Radius;
        }

        public override double Operation1()
        {
            throw new NotImplementedException();
        }
    }
}
