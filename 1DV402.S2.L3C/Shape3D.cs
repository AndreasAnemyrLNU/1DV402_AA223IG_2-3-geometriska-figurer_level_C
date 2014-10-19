using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public abstract class Shape3D : Shape, IComparable
    {
        protected Shape2D _baseShape;

        /// <summary>
        /// Height field of shape
        /// </summary>
        private double _height;
        /// <summary>
        /// Heigth prop of shape. Set prop controls incoming valut to be gt than 0
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ange en höjd större än 0");
                }
                _height = value;
            }


        }
        /// <summary>
        /// Return the Mantelarea of shape
        /// </summary>
        public abstract double MantelArea { get; }
        /// <summary>
        /// Returns TotalSurfaceArea of shape
        /// </summary>
        public abstract double TotalSurfaceArea { get; }
        /// <summary>
        /// Returns the Volume of shape
        /// </summary>
        public abstract double Volume { get; }
        /// <summary>
        /// Implemented becaus of Icomparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (null == obj)
            {
                return 1;
            }

            if (this == obj)
            {
                return 0;
            }
            Shape3D other = obj as Shape3D;
            if (null == other)
            {
                throw new ArgumentException("Object is not a shape");
            }
            //Look further at "CompareTo". Maybe a better impl can be done?
            return Volume.CompareTo(other.Volume);
        }
        /// <summary>
        /// Construcktor in cooperation with base constructor
        /// </summary>
        /// <param name="shapeType"></param>
        /// <param name="baseShape"></param>
        /// <param name="height"></param>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            :base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }
        /// <summary>
        /// ToString override to better match how output will look
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ToString("G");
        }

        public override string ToString(string format)
        {
            if (format == "G" || format == "" || format == null)
            {
                return string.Format("Längd            :{0,10:F1}\nBredd            :{1,10:F1}\nHöjd             :{2,10:F1}\nMantelarea       :{3,10:F1}\nBegränsningsarea :{4,10:F1}\nVolym            :{5,10:F1}", _baseShape.Length, _baseShape.Width, Height, MantelArea, TotalSurfaceArea, Volume);
            }
            else if (format == "R")
            {
              return string.Format("{0,-10}{1,6:F1}{2,6:F1}{3,6:F1}{4,13:F1}{5,15:F1}{6,13:F1}", ShapeType, _baseShape.Length, _baseShape.Width, Height, MantelArea, TotalSurfaceArea, Volume);
            }
            else
            {
                throw new FormatException();
            }
        }



    }
}
