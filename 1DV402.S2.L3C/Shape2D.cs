using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public abstract class Shape2D : Shape, IComparable
    {
        /// <summary>
        /// Length of Shape
        /// </summary>
        private double _length;
        /// <summary>
        /// Width of Shape
        /// </summary>
        private double _width;
        /// <summary>
        /// Area of Shape
        /// </summary>
        public abstract double Area
        {
            get;
        }
        /// <summary>
        /// Length Property of Shape. Set prop checks incoming vakue gt 0.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
               
                if(value <= 0)
                {                
                    throw new ArgumentException("Fel! Du måste ange alla dimensioner i ett tal över 0!");
                }
                _length = value;
            }
        }
        /// <summary>
        /// Perimeter of Shape
        /// </summary>
        public abstract double Perimeter
        {
            get;
        }
        /// <summary>
        /// Width Property of shape. Set prop checks incoming value gt 0.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fel! Du måste ange dimensioner i ett tal över 0!");
                }
                _width = value;
            }
        }
        /// <summary>
        /// Method implemented becaous of IComparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if(null == obj)
            {
                return 1;
            }

            if(this == obj)
            {
                return 0;
            }
            Shape2D other =  obj as Shape2D;
            if (null == other)
            {
                throw new ArgumentException("Object is not a shape");
            }
            //Maybe work further wit this method for better functionality
            return Area.CompareTo(other.Area);
        }
        /// <summary>
        /// Constructor in cooperation with the base constructor
        /// </summary>
        /// <param name="shapeType"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        protected Shape2D(ShapeType shapeType, double length, double width)
            :base(shapeType)
        {
            Length =length;
            Width = width;
        }
        /// <summary>
        /// ToString overrided for output
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
                return string.Format("Längd  :{0,10:F1}\nBredd  :{1,10:F1}\nOmkrets:{2,10:F1}\nArea   :{3,10:F1}", Length, Width, Perimeter, Area);
            }
            else if(format == "R")
            {
                return string.Format("{0,-10}{1,6:F1}{2,6:F1}{3,6:F1}{4,8:F1}",ShapeType,Length,Width,Perimeter,Area);
            }
            else
            {
                throw new FormatException();
            }
        }








    }
}
