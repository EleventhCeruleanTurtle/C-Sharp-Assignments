using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: To prompt the user to create shapes and then store and display those shapes.
///
namespace Lab2A
{
    public class Lab2
    {
        /// <summary>
        /// Displays the shapes the user cna create and keeps track of them in a list
        /// </summary>
        /// <param name="args"> Unused default parameter </param>
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Shape> shapes= new List<Shape>();

            while (true)
            {
                Console.WriteLine("\n1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Box");
                Console.WriteLine("4. Cube");
                Console.WriteLine("5. Ellipse");
                Console.WriteLine("6. Circle");
                Console.WriteLine("7. Cylinder");
                Console.WriteLine("8. Sphere");
                Console.WriteLine("9. Triangle");
                Console.WriteLine("10. Tetrahedron");
                Console.WriteLine("11. Display All Shapes");
                Console.WriteLine("12. Exit");
                Console.WriteLine("\nEnter Choice: ");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Rectangle rectangle = new Rectangle();
                    shapes.Add(rectangle);
                }
                else if (input == "2") 
                {
                    Square square = new Square();
                    shapes.Add(square);
                }
                else if (input == "3") 
                { 
                    Box box = new Box();
                    shapes.Add(box);
                }
                else if (input == "4") 
                {
                    Cube cube = new Cube();
                    shapes.Add(cube);
                }
                else if (input == "5") 
                {
                    Ellipse ellipse = new Ellipse();
                    shapes.Add(ellipse);
                }
                else if (input == "6") 
                {
                    Circle circle = new Circle();
                    shapes.Add(circle);
                }
                else if (input == "7") 
                {
                    Cylinder cylinder = new Cylinder();
                    shapes.Add(cylinder);
                }
                else if (input == "8") 
                {
                    Sphere sphere = new Sphere();
                    shapes.Add(sphere);
                }
                else if (input == "9") 
                {
                    Triangle triangle = new Triangle();
                    shapes.Add(triangle);
                }
                else if (input == "10") 
                {
                    Tetrahedron tetrahedron = new Tetrahedron();
                    shapes.Add(tetrahedron);
                }
                else if (input == "11") 
                {
                    Console.WriteLine("Shape        Area      Volume     Details");
                    Console.WriteLine("============ ========= ========== ======================================");
                    foreach (Shape shape in shapes)
                    {
                        Console.WriteLine(shape.ToString());
                    }
                    Console.WriteLine($"Count: {Shape.GetCount()}");
                }
                else if (input == "12")
                {
                    break;
                }
                else { Console.WriteLine("Please enter a valid number within the range 1-12."); }
            }
            }
    }
}
