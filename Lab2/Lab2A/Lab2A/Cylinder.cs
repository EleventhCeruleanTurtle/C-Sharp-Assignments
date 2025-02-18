using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Cylinder shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one cylinder shape
    /// </summary>
    public class Cylinder : Circle
    {
        protected double height; // Cylinder height

        /// <summary>
        /// Cylinder constructor that calls base.SetData and this.SetData
        /// </summary>
        public Cylinder() : base()
        {
            base.SetData();
        }

        /// <summary>
        /// Calculates the surface area of the Cylinder (2*Shape.PI*base.radius*this.height + 2*Shape.PI*base.radius*base.radius)
        /// </summary>
        /// <returns> 2 * Shape.PI * base.radius * this.height + 2 * Shape.PI * base.radius * base.radius </returns>
        public override double CalculateArea()
        {
            return 2 * Shape.PI * base.radius * this.height + 2 * Shape.PI * base.radius * base.radius;
        }

        /// <summary>
        ///  Calculates the volume of the Cube (Shape.PI*base.radius*base.radius*this.height)
        /// </summary>
        /// <returns> Shape.PI * base.radius * base.radius * this.height </returns>
        public override double CalculateVolume()
        {
            return Shape.PI * base.radius * base.radius * this.height;
        }

        /// <summary>
        /// Sets the height of the cylinder
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
        /// A string representation of the Cylinder class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Cylinder</returns>
        public override string ToString()
        {
            return $"{base.ToString()} x {this.height:F} h";
        }
    }
}
