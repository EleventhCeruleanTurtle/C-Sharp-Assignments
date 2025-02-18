using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Square shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one square shape
    /// </summary>
    public class Square : Shape
    {
        protected double length; // Square side length

        /// <summary>
        /// Square constructor that calls base.SetData and this.SetData
        /// </summary>
        public Square() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the square (length*length)
        /// </summary>
        /// <returns> length * length </returns>
        public override double CalculateArea()
        {
            return length * length;
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
        /// Sets the length of the square
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the side length: ");
                this.length = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Square class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Square</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.length:F} s x {this.length:F} s";
        }
    }
}
