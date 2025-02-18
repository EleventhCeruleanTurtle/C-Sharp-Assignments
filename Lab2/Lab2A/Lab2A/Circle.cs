using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Circle shape
///
namespace Lab2A
{
    public class Circle : Shape
    {
        protected double radius; // Circle radius

        /// <summary>
        /// Circle constructor that calls base.SetData and this.SetData
        /// </summary>
        public Circle() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the circle (PI*radius*radius)
        /// </summary>
        /// <returns> PI * radius * radius </returns>
        public override double CalculateArea()
        {
            return Shape.PI * radius * radius;
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
        /// Sets the radius of the circle
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the radius: ");
                this.radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Circle class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Circle</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.radius:F} r";
        }
    }
}
