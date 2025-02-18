using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a Cube shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one Cube shape
    /// </summary>
    public class Cube : Square
    {

        /// <summary>
        /// Calculates the surface area of the Cube (6*this.length*this.length)
        /// </summary>
        /// <returns> 6 * this.length * this.length </returns>
        public override double CalculateArea()
        {
            return 6 * this.length * this.length;
        }

        /// <summary>
        /// Calculates the volume of the Cube (this.length*this.length*this.length)
        /// </summary>
        /// <returns> this.length * this.length * this.length </returns>
        public override double CalculateVolume()
        {
            return this.length * this.length * this.length;
        }

        /// <summary>
        /// Calls the base setData() to set length
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
        /// A string representation of the Cube class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Cube</returns>
        public override string ToString()
        {
            return $"{base.ToString()} x {base.length:F} s";
        }
    }
}
