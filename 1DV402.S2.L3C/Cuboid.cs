using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public class Cuboid : Shape3D
    {
        public override double MantelArea
        {
            get
            {

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

        public Cuboid(double length, double width, double height)
            : base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
           //Empty 
        }




    }
}
