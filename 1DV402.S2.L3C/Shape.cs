using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{
    public abstract class Shape
    {

        public enum ShapeType { Rectangle, Circle, Ellipse, Cuboid, Cylinder, Sphere, };

        //Ska returnera true om figuren är någon av typerna Cuboid, cylinder eller Sphere
        public bool IsShape3d
        {
            get
            {
                return true;
            }
        }

        public ShapeType ShapeType{ get; private set; }

        //konstrukorn
        protected Shape(ShapeType shapeType)
        {
            //Tom
        }

        //Ska returnera en formaterad textbeskrivning av objektet
        public override string ToString(string format)
        {
            return base.ToString();
        }









    }
}
