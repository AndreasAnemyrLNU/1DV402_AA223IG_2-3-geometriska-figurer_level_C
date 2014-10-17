using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{
    class Program
    {
        //För varje gång ett rnd objekt rulla ökar slumtalsfröet med ETT
        private static int seed;
        //Variabel som håller referens till inläst objekt
        private static Shape shape;

        private static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;

                case ShapeType.Cuboid:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;

                case ShapeType.Cylinder:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;

                case ShapeType.Ellipse:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;

                case ShapeType.Rectangle:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;

                case ShapeType.Sphere:
                    FormatHead();
                    Console.WriteLine(Extensions.CenterAlignString(Extensions.AsText(shapeType), Properties.Resources.bHeadLine37));
                    Console.ResetColor();
                    break;
            }
       
            double[] dimensions = ReadDimensions(shapeType);

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(dimensions[0],dimensions[1]);

                case ShapeType.Circle:
                    return new Ellipse(dimensions[0]);

                case ShapeType.Ellipse:
                    return new Ellipse(dimensions[0],dimensions[1]);

                case ShapeType.Cuboid:
                    return new Cuboid(dimensions[0],dimensions[1],dimensions[2]);

                case ShapeType.Cylinder:
                    return new Cylinder(dimensions[0],dimensions[1],dimensions[2]);

                case ShapeType.Sphere:
                    return new Sphere(dimensions[0]);

                default:
                    return null;
            }

        }

        private static Shape2D[] Randomize2DShapes()
                    //private static void Randomize2DShapes()
        {
            Random rndObjects = new Random(seed);

            int nrOfObjectsToRandomize = rndObjects.Next(5, 21);

            //Skapar en arry med rätt antal objekt
            Shape2D[] Shape2Ds = new Shape2D[nrOfObjectsToRandomize];

            for (int i = 0; i < nrOfObjectsToRandomize; i++)
            {
                //Slumpar ett ta från O till 2 typomvandlas till ett ShapeType enum
                ShapeType shapeType = (ShapeType)rndObjects.Next(1,4);
           
                switch (shapeType)
                {
                case ShapeType.Rectangle:
                     Shape2Ds[i] = new Rectangle(RndDoubleGen(), RndDoubleGen());
                     continue;

                case ShapeType.Circle:
                    Shape2Ds[i] = new Ellipse(RndDoubleGen());
                    continue;

                case ShapeType.Ellipse:
                    Shape2Ds[i] = new Ellipse(RndDoubleGen(),RndDoubleGen());
                    continue;
                }
            }
            //Returnerner härmed en randomiserad shape2D array
            //Eventuellt skulle man kunna ta bort seed++ då den eventuellt inte behövs i denna metoden           
            seed++;
            return Shape2Ds;
        }

        private static Shape3D[] Randomize3DShapes()
        {
            Random rndObjects = new Random(seed);

            int nrOfObjectsToRandomize = rndObjects.Next(5, 21);

            //Skapar en arry med rätt antal objekt
            Shape3D[] Shape3Ds = new Shape3D[nrOfObjectsToRandomize];

            for (int i = 0; i < nrOfObjectsToRandomize; i++)
            {
                //Slumpar ett ta från O till 2 typomvandlas till ett ShapeType enum
                ShapeType shapeType = (ShapeType)rndObjects.Next(4, 7);

                switch (shapeType)
                {
                    case ShapeType.Cuboid:
                        Shape3Ds[i] = new Cuboid(RndDoubleGen(), RndDoubleGen(), RndDoubleGen());
                        continue;

                    case ShapeType.Cylinder:
                        Shape3Ds[i] = new Cylinder(RndDoubleGen(), RndDoubleGen(), RndDoubleGen());
                        continue;

                    case ShapeType.Sphere:
                        Shape3Ds[i] = new Sphere(RndDoubleGen());
                        continue;
                }
            }
            //Returnerner härmed en randomiserad shape3D array
            //Eventuellt skulle man kunna ta bort seed++ då den eventuellt inte behövs i denna metoden           
            seed++;
            return Shape3Ds;  
        }

        private static double[] ReadDimensions(ShapeType shapetype)
        {

            double[] doubles;

            switch (shapetype)
            {

                case ShapeType.Circle:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens diameter:", 1);
                    break;

                case ShapeType.Cuboid:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens längd, bredd och höjd:", 3);
                    break;

                case ShapeType.Cylinder:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens längd, bredd och höjd:", 3);
                    break;

                case ShapeType.Ellipse:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens längd och bredd:", 2);
                    break;

                case ShapeType.Rectangle:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens längd och bredd:", 2);
                    break;

                case ShapeType.Sphere:
                    doubles = ReadDoublesGreaterThanZero("Ange figurens längd, bredd och djup:", 3);
                    break;
                default:
                    doubles = null;
                    break;
            }
            return doubles;
        }

        private static double[] ReadDoublesGreaterThanZero(string prompt, int numberOfvalues = 1)
        {
            Console.Write("{0}", prompt);

            string dimensionsString = Console.ReadLine();

            string[] dimensionsArr = dimensionsString.Split();

            //Kontroller så att inget av värden är 0 eller lägra för då ska jag kaste ett fel


            for (int i = 0; i < dimensionsArr.Length; i++ )
            {
                if (double.Parse(dimensionsArr[i]) <= 0)
                {
                    Console.WriteLine("Fel! Ett fel inträffade då figurens dimensioner tolkades");
                }
            }

                switch (numberOfvalues)
                {
                    case 1:
                        return new double[1] { double.Parse(dimensionsArr[0]) };

                    case 2:
                        return new double[2] { double.Parse(dimensionsArr[0]), double.Parse(dimensionsArr[1]) };

                    case 3:
                        return new double[3] { double.Parse(dimensionsArr[0]) , double.Parse(dimensionsArr[1]) , double.Parse(dimensionsArr[2]) };
                   
                    default:
                        return null;
                }       
        }

        private static void ViewMenu()
        {        
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Extensions.CenterAlignString("Geometriska figurer", Properties.Resources.bHeadLine37));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("{0}", Properties.Resources.aMenuCancel);
                Console.WriteLine("{0}", Properties.Resources.aMenuRectangle);
                Console.WriteLine("{0}", Properties.Resources.aMenuCirkel);
                Console.WriteLine("{0}", Properties.Resources.aMenuEllipse);
                Console.WriteLine("{0}", Properties.Resources.aMenuCuboid);
                Console.WriteLine("{0}", Properties.Resources.aMenuCylinder);
                Console.WriteLine("{0}", Properties.Resources.aMenuSphere);
                Console.WriteLine("{0}", Properties.Resources.aRandomize2D);
                Console.WriteLine("{0}", Properties.Resources.aRandomize3D);
                Console.WriteLine("\n{0}\n", Properties.Resources.bHeadLine37);
                Console.Write(" Ange menyval [0-8]: ");
                Console.ResetColor();
        }

        private static void ViewMenuErrorMessage()
        {
            throw new NotImplementedException();
        }

        private static void ViewShapeDetail(Shape shape)
        {
            FormatHead();
            Console.WriteLine(Extensions.CenterAlignString("Detaljer", Properties.Resources.bHeadLine37));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(shape.ToString());
        }

        private static void ViewShapes(Shape[] shapes) 
        {
            if (shapes[0].IsShape3d == true)
            {
                Console.Clear();
                FormatHead();
                Console.WriteLine("=====================================================================");
                Console.WriteLine(Properties.Resources.bHeadViewShapes3DHeading);
                Console.WriteLine("=====================================================================");

                Console.ResetColor();
            }
            if (shapes[0].IsShape3d == false)
            {
                Console.Clear();
                FormatHead();
                Console.WriteLine("====================================");
                Console.WriteLine(Properties.Resources.bHeadViewShapes2DHeading);
                Console.WriteLine("====================================");
                Console.ResetColor();
            }

            foreach(Shape shape in shapes)
            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(shape.ToString("R"));
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Geometriska figurer - nivå C";

            int index;
            ShapeType shapeType = ShapeType.Indefinite;

            //Här läser man in valet för shapen man vill göra
            do
            {
                ViewMenu();
                // Läser in en sträng som försöker tolkas till ett heltal; validerar sedan att 
                // det inmatade heltalet är i det slutna intervallet mellan 0 och 8. 
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 8)
                {
                    shapeType = (ShapeType)index;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 8.\n");
                    Console.ResetColor();
                }
            } while (index == 0);

            switch (index)

            {
                case 1:
                    shape = CreateShape(ShapeType.Rectangle);
                    ViewShapeDetail(shape);
                    break;

                case 2:
                     shape = CreateShape(ShapeType.Circle);
                     ViewShapeDetail(shape);
                    break;                   

                case 3:
                    shape = CreateShape(ShapeType.Ellipse);
                    ViewShapeDetail(shape);
                    break;

                case 4:
                    shape = CreateShape(ShapeType.Cuboid);
                    ViewShapeDetail(shape);
                    break;

                case 5:
                    shape = CreateShape(ShapeType.Cylinder);
                    ViewShapeDetail(shape);
                    break;

                case 6:
                    shape = CreateShape(ShapeType.Sphere);
                    ViewShapeDetail(shape);
                    break;

                case 7:
                    Shape[] Shape2ds = Randomize2DShapes();
                    Array.Sort(Shape2ds);
                    ViewShapes(Shape2ds);
                    break;

                case 8:
                    Shape[] Shape3ds = Randomize3DShapes();
                    Array.Sort(Shape3ds);
                    ViewShapes(Shape3ds);
                    break;
            }

            Console.Read();
        }

        public static double RndDoubleGen()
        {
            Random rnd = new Random(seed);
            int first = rnd.Next(0, 100);
            double second =rnd.NextDouble();
            double randomizedDouble = first + second;
            seed++;
            return randomizedDouble;
        }

        private static void ContinueOnKeyPressed()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n   Tryck tangent för att fortsätta   ");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }

        private static void FormatHead()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

     
    } 
 } 

