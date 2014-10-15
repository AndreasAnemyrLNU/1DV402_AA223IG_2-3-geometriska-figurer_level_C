using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{


    public enum ShapeType { Rectangle, Circle, Ellipse, Cuboid, Cylinder, Sphere, };

    public abstract class Shape
    {


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
            ShapeType = shapeType;
        }

        //Ska returnera en formaterad textbeskrivning av objektet
        public abstract string ToString(string format);









    }
}
