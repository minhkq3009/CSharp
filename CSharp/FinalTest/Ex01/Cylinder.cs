using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.FinalTest.Ex01
{
    internal class Cylinder
    {
        public double Radius { get; private set; }
        public double Height { get; private set; }
        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }

        public void Process()
        {
            // Input Radius and Height from user
            Console.Write("Enter the radius of the cylinder: ");
            Radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            Height = double.Parse(Console.ReadLine());

            // Calculate BaseArea, LateralArea, TotalArea, and Volume
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            // Display the results
            Console.WriteLine($"Base Area of Cylinder: {BaseArea}");
            Console.WriteLine($"Lateral Area of Cylinder: {LateralArea}");
            Console.WriteLine($"Total Area of Cylinder: {TotalArea}");
            Console.WriteLine($"Volume of Cylinder: {Volume}");
        }
    }
}
