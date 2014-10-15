using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public class Cylinder : Shape3D
    {
                public override double MantelArea
        {
            get
            {
                return _baseShape.Perimeter * base.Height;
                
            }
        }

        public override double TotalSurfaceArea
        {
            get
            {
                return MantelArea + 2 * _baseShape.Area;
            }
        }

        public override double Volume
        {
            get 
            {
                return _baseShape.Area * base.Height;
            }
        }

        public Cylinder(double length, double width, double height)
            : base(ShapeType.Cylinder, new Ellipse(length, width), height)
        {
           //Empty 
        }
    }
}
