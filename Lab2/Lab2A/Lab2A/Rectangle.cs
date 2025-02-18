using Lab2A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a rectangle shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one rectangle shape
    /// </summary>
    public class Rectangle : Shape
    {
        protected double length;    // Rectangle length
        protected double width;     // Rectangle width

        /// <summary>
        /// Rectangle constructor that calls base.SetData and this.SetData
        /// </summary>
        public Rectangle() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the rectangle (length*width)
        /// </summary>
        /// <returns> length * width </returns>
        public override double CalculateArea()
        {
            return length * width;
        }

        /// <summary>
        /// Used method from Shape class
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Sets the length and width of the rectangle
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the length: ");
                this.length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width: ");
                this.width = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Rectangle class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Rectangle</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.length:F} l x {this.width:F} w";
        }
    }
}
