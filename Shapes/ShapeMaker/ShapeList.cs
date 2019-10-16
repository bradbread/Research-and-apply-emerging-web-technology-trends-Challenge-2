using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shapes;

namespace ShapeMaker
{
    //probs should break this into multiple classes
    class ShapeList
    {
        List<Square> squares;
        List<Rectangle> rectangles;
        List<Equilateral> equilaterals;
        List<RightAngle> rightangles;
        List<Circle> circles;

        public ShapeList()
        {
            squares = new List<Square>();
            rectangles = new List<Rectangle>();
            equilaterals = new List<Equilateral>();
            rightangles = new List<RightAngle>();
            circles = new List<Circle>();

        }
        public void DisplayAllShapes()
        {
            DisplaySquares();
            DisplayRectangles();
            DisplayEquilaterals();
            DisplayRightAngles();
            DisplayCircles();
        }

        public void DisplaySquares()
        {
            DisplaySeperator();
            try
            {
                if (squares.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of square list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Squares");
                    for (int i = 0; i < squares.Count; i++)
                    {
                        Console.WriteLine("Square " + i + ": Colour: " + squares[i].Colour + " SideLength = " + squares[i].SideLength1);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DisplayRectangles()
        {
            DisplaySeperator();
            try
            {
                if (rectangles.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of rectangle list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Rectangles");
                    for (int i = 0; i < rectangles.Count; i++)
                    {
                        Console.WriteLine("Rectangle " + i + ": Colour: " + rectangles[i].Colour + " Side1Length = " + rectangles[i].SideLength1 + " Side2Length = " + rectangles[i].SideLength2);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayEquilaterals()
        {
            DisplaySeperator();
            try
            {
                if (equilaterals.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of equilateral list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Equilaterals");
                    for (int i = 0; i < equilaterals.Count; i++)
                    {
                        Console.WriteLine("Equilateral " + i + ": Colour: " + equilaterals[i].Colour + " SideLength = " + equilaterals[i].SideLength1);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DisplayRightAngles()
        {
            DisplaySeperator();
            try
            {
                if (rightangles.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of right angle triangle list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Right Angle Triangles");
                    for (int i = 0; i < rightangles.Count; i++)
                    {
                        Console.WriteLine("Right Angle Triangle " + i + ": Colour: " + rightangles[i].Colour + " Side1Length = " + rightangles[i].SideLength1 + " Side2Length = " + rightangles[i].SideLength2 + " Side3Length = " + rightangles[i].SideLength3);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayCircles()
        {
            DisplaySeperator();
            try
            {
                if (circles.Count < 1)
                {
                    throw (new LengthLessThanOneException("Length of circle list less than one"));
                }
                else
                {
                    Console.WriteLine("Current Circles");
                    for (int i = 0; i < circles.Count; i++)
                    {
                        Console.WriteLine("Circle " + i + ": Colour: " + circles[i].Colour + " SideLength = " + circles[i].Radius);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DisplaySeperator()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }

        public double AddLength(string message)
        {
            Console.WriteLine(message);
            double x = 0;
            //remember to catch more specific exceptions
            //also probably a much better way to do this
            try
            {
                x = double.Parse(Console.ReadLine());

                if (x < 1)
                {
                    throw (new LengthLessThanOneException("Side Length less than 1 Exception"));
                }

                if (x % 1 != 0)
                {
                    throw (new DecimalPointEception("Entered Side Length Is a Decimal Exception"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return 0;
            }

            return x;

        }

        public string AddColour(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void AddSquare()
        {
            Console.Clear();
            double x = AddLength("What is the length of your square?");
            if (x < 1)
            {
                return;
            }
            squares.Add(new Square(x));
        }

        public void AddRectangle()
        {
            Console.Clear();
            double x = AddLength("What is the length of your first side");
            if (x < 1)
            {
                return;
            }
            double y = AddLength("What is the length of your second side");
            if (y < 1)
            {
                return;
            }
            rectangles.Add(new Rectangle(x, y));
        }

        public void AddEquilateral()
        {
            Console.Clear();
            double x = AddLength("What is the side length of your equilateral?");
            if (x < 1)
            {
                return;
            }
            equilaterals.Add(new Equilateral(x));
        }

        public void AddRightAngle()
        {
            Console.Clear();
            Console.WriteLine("Enter sides a and b side c will be calculated for you");
            double x = AddLength("What is the length of your first side");
            if (x < 1)
            {
                return;
            }
            double y = AddLength("What is the length of your second side");
            if (y < 1)
            {
                return;
            }
            rightangles.Add(new RightAngle(x, y));
        }

        public void AddCircle()
        {
            Console.Clear();
            double x = AddLength("What is the radius of your circle?");
            if (x < 1)
            {
                return;
            }
            Circle temp = new Circle();
            temp.Radius = x;
            circles.Add(temp);
        }

        public void DisplaySInput()
        {
            Console.Clear();
            DisplaySquares();
            Console.ReadLine();
        }

        public void DisplayRInput()
        {
            Console.Clear();
            DisplayRectangles();
            Console.ReadLine();
        }

        public void DisplayEInput()
        {
            Console.Clear();
            DisplayEquilaterals();
            Console.ReadLine();
        }

        public void DisplayRAInput()
        {
            Console.Clear();
            DisplayRightAngles();
            Console.ReadLine();
        }

        public void DisplayCInput()
        {
            Console.Clear();
            DisplayRightAngles();
            Console.ReadLine();
        }

        public void DisplayAInput()
        {
            Console.Clear();
            DisplayAllShapes();
            Console.ReadLine();
        }

    }
}
