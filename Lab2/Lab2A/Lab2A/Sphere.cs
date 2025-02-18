using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Sphere shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one sphere shape
    /// </summary>
    public class Sphere : Circle
    {
        /// <summary>
        /// Calculates the surface area of the Sphere (4*Shape.PI*base.radius*base.radius)
        /// </summary>
        /// <returns> 4 * Shape.PI * base.radius * base.radius </returns>
        public override double CalculateArea()
        {
            return 4 * Shape.PI * base.radius * base.radius;
        }

        /// <summary>
        ///  Calculates the volume of the Sphere (4.0/3.0*Shape.PI*base.radius*base.radius*base.radius)
        /// </summary>
        /// <returns> 4.0/3.0 * Shape.PI * base.radius * base.radius * base.radius </returns>
        public override double CalculateVolume()
        {
            return 4.0/3.0 * Shape.PI * base.radius * base.radius * base.radius;
        }

        /// <summary>
        /// Calls the base setData() to set radius
        /// </summary>
        public override void SetData()
        {
            try
            {
                base.SetData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Sphere class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Sphere</returns>
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
