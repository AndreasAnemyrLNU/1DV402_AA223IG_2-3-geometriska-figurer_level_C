using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{
    public static class Extensions
    {
        public static string AsText(this ShapeType  shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return "Rektangel";

                case ShapeType.Circle:
                    return "Cirkel";

                case ShapeType.Ellipse:
                    return "Ellipse";

                case ShapeType.Cuboid:
                    return "Rätblock";

                case ShapeType.Cylinder:
                    return "Cylinder";

                case ShapeType.Sphere:
                    return "Sfär";                    
            }
            return "No data match for ShapeType enum";
        }

        public static string CenterAlignString(this string s, string other)
        {
            //Centretar en rubrik med ojämn textsträng other
            if (s.Length % 2 == 0)
            {
                string str = other;

                int space = (((other.Length - s.Length) - 2) / 2);

                str += "=";
                    for (int i = 0; i < space; i++)
                    {
                        str += (" ");
                    }              
                        str += s;
                    for (int i = 0; i < space - 1; i++)
                    {
                        str += (" ");
                    }
                str += "=\n";
                str += other;
                return str;
            }
            //Centretar en rubrik med ojämn textsträng other
            else
            {
                string str = other;

                int space = (((other.Length - s.Length) - 2) / 2);

                str += "=";
                for (int i = 0; i < space; i++)
                {
                    str += (" ");
                }
                str += s;
                for (int i = 0; i < space - 1; i++)
                {
                    str += (" ");
                }
                str += " =\n";
                str += other;
                return str;
            }
        }
    }
}
