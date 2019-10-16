using System;

namespace ShapeMaker
{
    class Program
    {
        static ShapeList myShapeList = new ShapeList();
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Maker");


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pick an option:");
                Console.WriteLine(" (1) -> Create Square");
                Console.WriteLine(" (2) -> Create Rectangle");
                Console.WriteLine(" (3) -> Create Equialateral Triangle");
                Console.WriteLine(" (4) -> Create Right Angle Triangle");
                Console.WriteLine(" (5) -> Create Circle");
                Console.WriteLine(" (6) -> Display All Shapes");
                Console.WriteLine(" (7) -> Display Squares");
                Console.WriteLine(" (8) -> Display Rectangles");
                Console.WriteLine(" (9) -> Display Equialateral Triangle");
                Console.WriteLine(" (0) -> Display Right Angle Triangle");
                Console.WriteLine(" (esc) -> Exit");



                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.D1)
                {
                    myShapeList.AddSquare();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    myShapeList.AddRectangle();
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    myShapeList.AddEquilateral();
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    myShapeList.AddRightAngle();
                }
                else if (key.Key == ConsoleKey.D5)
                {
                    myShapeList.AddCircle();
                }
                else if (key.Key == ConsoleKey.D6)
                {
                    myShapeList.DisplayAInput();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey(true);
                }

            }

        }
    }
}
