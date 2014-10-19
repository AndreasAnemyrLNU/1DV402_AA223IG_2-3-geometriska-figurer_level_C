using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{

    /// <summary>
    /// All shapes in this app listed in an enum
    /// </summary>
    public enum ShapeType { Indefinite, Rectangle, Circle, Ellipse, Cuboid, Cylinder, Sphere };

    public abstract class Shape
    {


        /// <summary>
        /// Return true if shape is of type 3D
        /// </summary>
        public bool IsShape3d
        {
            get
            {
                if(ShapeType == ShapeType.Ellipse || ShapeType == ShapeType.Rectangle || ShapeType == ShapeType.Circle)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public ShapeType ShapeType{ get; private set; }

        /// <summary>
        /// All shapes are unique
        /// </summary>
        /// <param name="shapeType"></param>
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        /// <summary>
        /// Returns an formatted string of obect. Must be overrided because of abstract
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public abstract string ToString(string format);









    }
}
