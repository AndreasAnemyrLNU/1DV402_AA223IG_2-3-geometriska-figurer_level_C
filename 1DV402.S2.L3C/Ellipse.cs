using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public class Ellipse : Shape2D
    {
        //Ellipse formel are PI * A * B
        public override double Area
        {
            get
            {
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * a * b;
            }
        }

        public override double Perimeter
        {
            get
            {
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }

        public Ellipse(double diameter) 
            :this(diameter, diameter)  
        { }

        public Ellipse(double hdiamter, double vdiameter) 
            :base(ShapeType.Ellipse, hdiamter, vdiameter)
        { }


    }
}
