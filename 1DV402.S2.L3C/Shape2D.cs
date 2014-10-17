using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public abstract class Shape2D : Shape, IComparable
    {
        //Figurens längd
        private double _length;
        //Figurens bredd
        private double _width;
        //Abstrakt method som måste implementeras i klass som ärver från denna
        public abstract double Area
        {
            get;
        }
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
                    //Kasta undantag om värdet är mindre än 0
                    try
                    {
                        throw new ArgumentException("Fel! Du måste ange alla dimensioner i ett tal över 0!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                _length = value;
            }
        }

        public abstract double Perimeter
        {
            get;
        }

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
                    //Kasta undantag om värdet är mindre än 0
                    try
                    {
                        throw new ArgumentException("Fel! Du måste ange dimensioner i ett tal över 0!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                _width = value;
            }
        }

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
            //Frågan är om ytterligare sortering ska göras?
            return Area.CompareTo(other.Area);
        }

        protected Shape2D(ShapeType shapeType, double length, double width)
            :base(shapeType)
        {
            Length =length;
            Width = width;
        }

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
