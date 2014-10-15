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
                    throw new ArgumentException();
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
                    throw new ArgumentException();
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
            return base.ToString();
        }

        public override string ToString(string format)
        {
            return "Dena är inte implementerad ännu...";
        }








    }
}
