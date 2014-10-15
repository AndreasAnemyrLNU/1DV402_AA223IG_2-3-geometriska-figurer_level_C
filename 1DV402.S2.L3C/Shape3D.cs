using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1DV402.S2.L3C
{
    public abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;

        private double _height;

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
                    //Kasta undantag om värdet är mindre än 0
                    throw new ArgumentException("Ange en höjd större än 0");
                }
                _height = value;
            }


        }

        public abstract double MantelArea { get; }

        public abstract double TotalSurfaceArea { get; }

        public abstract double Volume { get; }

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
            //Frågan är om ytterligare sortering ska göras?
            return Volume.CompareTo(other.Volume);
        }

        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            :base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

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
                return string.Format("{0,-10}{1,6:F1}{2,6:F1}{3,6:F1}{4,13:F1}{5,13:F1},{6,13F1}", ShapeType, _baseShape.Length, _baseShape.Width, Height, MantelArea, TotalSurfaceArea, Volume );
            }
            else
            {
                throw new FormatException();
            }
        }



    }
}
