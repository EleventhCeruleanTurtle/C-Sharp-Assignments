using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a tetrahedron shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one tetrahedron shape
    /// </summary>
    public class Tetrahedron : Shape
    {
        protected double edge; // the edge of the tetrahedron

        /// <summary>
        /// Tetrahedron constructor that calls base.SetData and this.SetData
        /// </summary>
        public Tetrahedron() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the tetrahedron (Math.Sqrt(3)*edge*edge)
        /// </summary>
        /// <returns> Math.Sqrt(3)*edge*edge </returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3)*edge*edge;
        }

        /// <summary>
        ///  Calculates the volume of the Tetrahedron ((edge*edge*edge)/(6.0*(Math.Sqrt(2))))
        /// </summary>
        /// <returns> (edge*edge*edge) / (6.0*(Math.Sqrt(2))) </returns>
        public override double CalculateVolume()
        {
            return (edge*edge*edge) / (6.0*(Math.Sqrt(2)));
        }

        /// <summary>
        /// Sets the edge of the tetrahedron
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the edge: ");
                this.edge = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Tetrahedron class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Tetrahedron</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.edge:F} edge";
        }
    }
}
