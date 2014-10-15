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
                return 4 / 3 * _baseShape.Area * base.Height / 2;
            }
        }

        public Sphere(double length, double width, double height)
            : base(ShapeType.Sphere, new Ellipse(length, width), height)
        {
           //Empty 
        }
    }
}
