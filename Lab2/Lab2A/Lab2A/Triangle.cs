using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Date:    October 5, 2024
/// Purpose: Create a triangle shape
///
namespace Lab2A
{
    /// <summary>
    /// This class represents one triangle shape
    /// </summary>
    public class Triangle : Shape
    {
        private double length; // Triangle base length
        private double height; // Triangle height

        /// <summary>
        /// Triangle constructor that calls base.SetData and this.SetData
        /// </summary>
        public Triangle() : base()
        {
            this.SetData();
        }

        /// <summary>
        /// Calculates the area of the triangle ((height*length)/2)
        /// </summary>
        /// <returns> (height * length)/2 </returns>
        public override double CalculateArea()
        {
            return (height * length)/2;
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
        /// Sets the base and height of the triangle
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.WriteLine("Enter the base: ");
                this.length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height: ");
                this.height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid entry.");
            }
        }

        /// <summary>
        /// A string representation of the triangle class
        /// </summary>
        /// <returns> The type, area, volume, and dimensions of the Triangle</returns>
        public override string ToString()
        {
            return $"{this.GetType().Name,-11} {CalculateArea(),10:F} {CalculateVolume(),10:F} {this.length:F} b x {this.height:F} h";
        }
    }
}
