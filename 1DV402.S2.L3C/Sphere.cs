using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public class Sphere : Shape3D
    {
                public override double MantelArea
        {
            get
            {
                return _baseShape.Area * 4;
            }
        }

        public override double TotalSurfaceArea
        {
            get
            {
                return _baseShape.Area * 4;
            }
        }

        public override double Volume
        {
            get 
            {
                double radius = _baseShape.Width / 2;
                
                //Formel för att räkna ut volym på en sfär.
                return 4 * Math.PI * Math.Pow(radius, 3) / 3;


                // Formel enligt handledning 4 / 3 * basarea * r
                //return 4 / 3 * _baseShape.Area * radius;
            }
        }

        public Sphere(double radius)
            : base(ShapeType.Sphere, new Ellipse(radius), radius)
        {
           //Empty 
        }
    }
}
