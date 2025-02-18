using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a ellipse shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one ellipse shape
    /// </summary>
    public class Ellipse : Shape
    {
        protected double semiMajor;    // Ellipse semi major
        protected double semiMinor;     // Ellipse semi minor

        /// <summary>
        /// Ellipse constructor that calls base.SetData and this.SetData
        /// </summary>
        public Ellipse() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the ellipse (Shape.PI*semiMajor*semiMinor)
        /// </summary>
        /// <returns> Shape.PI * semiMajor * semiMinor </returns>
        public override double CalculateArea()
        {
            return Shape.PI * semiMajor * semiMinor;
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
        /// Sets the semi major and semi minor of the ellipse
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the semiMajor: ");
                this.semiMajor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the semiMinor: ");
                this.semiMinor = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the Ellipse class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Ellipse</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.semiMinor:F} sminor x {this.semiMajor:F} smajor";
        }
    }
}
