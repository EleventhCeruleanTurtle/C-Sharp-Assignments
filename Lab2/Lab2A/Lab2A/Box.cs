using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Box shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one Box shape
    /// </summary>
    public class Box : Rectangle
    {
        private double height; // Box height

        /// <summary>
        /// Box constructor that calls base.SetData and this.SetData
        /// </summary>
        public Box() : base()
        {
            base.SetData();
        }

        /// <summary>
        /// Calculates the surface area of the Box (2*base.CalculateArea() + 2*height*base.length + 2*height*base.width)
        /// </summary>
        /// <returns> 2 * base.CalculateArea() + 2 * height * base.length + 2 * height * base.width </returns>
        public override double CalculateArea()
        {
            return 2 * base.CalculateArea() + 2 * height * base.length + 2 * height * base.width;
        }

        /// <summary>
        /// Calculates the volume of the Box (base.CalculateArea()*height)
        /// </summary>
        /// <returns> base.CalculateArea() * height </returns>
        public override double CalculateVolume()
        {
            return base.CalculateArea() * height;
        }

        /// <summary>
        /// Sets the height of the Box
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the height: ");
                this.height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Box class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Box</returns>
        public override string ToString()
        {
            return $"{base.ToString()} x {this.height:F} h";
        }
    }
}
