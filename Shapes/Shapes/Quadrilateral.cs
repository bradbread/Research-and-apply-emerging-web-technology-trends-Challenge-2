using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
     public abstract class Quadrilateral : Shape, IShapeCalc
    {
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double SideLength3 { get; set; }
        public double SideLength4 { get; set; }

        public abstract double GetArea();


        public abstract double GetPerimeter();

    }
}
