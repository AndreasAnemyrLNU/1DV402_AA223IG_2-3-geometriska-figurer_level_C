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
                throw new NotImplementedException();
            }
        }

        public override double TotalSurfaceArea
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override double Volume
        {
            get 
            { 
                throw new NotImplementedException(); 
            }
        }

        public Cylinder(double length, double width, double height)
            : base(ShapeType.Cylinder, new Ellipse(length, width), height)
        {
           //Empty 
        }
    }
}
