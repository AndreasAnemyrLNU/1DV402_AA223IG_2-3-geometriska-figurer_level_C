﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{
    class Program
    {

        /// <summary>
        /// Makes it possible to randomizing the seed becaus of it's static in this class. 
        /// Before leaving a rnd obj to the garbage cllector a new seed should be randomized wit next()
        /// </summary>
        private static int seed;
        /// <summary>
        /// Holds reference to shape object
        /// </summary>
        private static Shape shape;
        /// <summary>
        /// Switch that uses the enums in shape.cs
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method called when index 7 is choosen in the menu
        /// </summary>
        /// <returns></returns>
        private static Shape2D[] Randomize2DShapes()
                    //private static void Randomize2DShapes()
        {         
            Random rndObjects = new Random();

            seed = rndObjects.Next();

            int nrOfObjectsToRandomize = rndObjects.Next(5, 21);


            Shape2D[] Shape2Ds = new Shape2D[nrOfObjectsToRandomize];

            for (int i = 0; i < nrOfObjectsToRandomize; i++)
            {
                //Rand 0,1 or 2. Typecasts to an shapetype enum
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
            //Returns herenow a randomized array of 2D shapes          
            seed++;
            return Shape2Ds;
        }

        private static Shape3D[] Randomize3DShapes()
        {
            Random rndObjects = new Random();

            seed = rndObjects.Next();

            int nrOfObjectsToRandomize = rndObjects.Next(5, 21);

            //Creates an array with  of objects between 5 & 20
            Shape3D[] Shape3Ds = new Shape3D[nrOfObjectsToRandomize];

            for (int i = 0; i < nrOfObjectsToRandomize; i++)
            {
                //Rand 4,5 or 6 and typecast explicite to a sahpetype from shapetype enums
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
            //Returns here a randomizes array of 3D shapes          
            seed++;
            return Shape3Ds;  
        }
        private static double[] ReadDimensions(ShapeType shapetype)
        {
                double[] doubles;

                switch (shapetype)
                {

                    case ShapeType.Circle:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimCircle, 1);
                        break;

                    case ShapeType.Cuboid:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimCuboid, 3);
                        break;

                    case ShapeType.Cylinder:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimCylinder, 3);
                        break;

                    case ShapeType.Ellipse:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimEllipse, 2);
                        break;

                    case ShapeType.Rectangle:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimRectangle, 2);
                        break;

                    case ShapeType.Sphere:
                        doubles = ReadDoublesGreaterThanZero(Properties.Resources.dDimSphere, 1);
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



                switch (numberOfvalues)
                {

                    case 1:
                        return new double[1] { double.Parse(dimensionsArr[0]) };

                    case 2:
                        return new double[2] { double.Parse(dimensionsArr[0]), double.Parse(dimensionsArr[1]) };

                    case 3:
                        return new double[3] { double.Parse(dimensionsArr[0]), double.Parse(dimensionsArr[1]), double.Parse(dimensionsArr[2]) };
                } 

            return null;
        }


        private static void ViewMenu()
        {        
                Console.Clear();
                FormatHead();
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

        private static void ViewMenuErrorMessage(string errorMessage)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(errorMessage);
;
            Console.ResetColor();
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
            Console.Title = Properties.Resources.cHeading;

            int index;
            ShapeType shapeType = ShapeType.Indefinite;

            //Här läser man in valet för shapen man vill göra
            do
            {
                ViewMenu();
                // Läser in en sträng som försöker tolkas till ett heltal; validerar sedan att 
                // det inmatade heltalet är i det slutna intervallet mellan 0 och 8. 

                if (int.TryParse(Console.ReadLine(), out index) && index >= 1 && index <= 6)
                {
                    shapeType = (ShapeType)index;

                    try
                    {
                        switch (shapeType)
                        {
                            case ShapeType.Indefinite:
                                break;

                            case ShapeType.Rectangle:
                                CreateShapeAndView(shapeType);
                                break;

                            case ShapeType.Circle:
                                CreateShapeAndView(shapeType);
                                break;

                            case ShapeType.Ellipse:
                                CreateShapeAndView(shapeType);
                                break;

                            case ShapeType.Cuboid:
                                CreateShapeAndView(shapeType);
                                break;

                            case ShapeType.Cylinder:
                                CreateShapeAndView(shapeType);
                                break;

                            case ShapeType.Sphere:
                                CreateShapeAndView(shapeType);
                                break;
                        }
                    }
                    catch (IndexOutOfRangeException){
                        ViewMenuErrorMessage("Fel! Var noga med att ange ett tal för samtliga dimensioner för gällande figur");
                    }
                    catch (ArgumentException e)
                    {
                        ViewMenuErrorMessage(e.Message);
                    }
                    catch (FormatException)
                    {
                        ViewMenuErrorMessage("Fel!  Ett fel inträffade då figurens dimensioner tolkades.");
                    }
                    catch (Exception e)
                    {
                        ViewMenuErrorMessage(e.Message);
                    }

                }
                else if (index == 7)
                    {
                        Shape[] Shape2ds = Randomize2DShapes();
                        Array.Sort(Shape2ds);
                        ViewShapes(Shape2ds); ;
                    }
                else if (index == 8)

                    {
                        Shape[] Shape3ds = Randomize3DShapes();
                        Array.Sort(Shape3ds);
                        ViewShapes(Shape3ds);
                    }
                else
                {
                    ViewMenuErrorMessage("Fel! Ange ett giltigt värde för menyn. Försök igen.");
                }
            }while (ContinueOnKeyPressed(index));
        }

        public static double RndDoubleGen()
        {
            Random rnd = new Random(seed);
            int first = rnd.Next(0, 100);
            double second = rnd.NextDouble();
            double randomizedDouble = first + second;
            seed = rnd.Next();
            return randomizedDouble;
        }
        /// <summary>
        /// Methos used by do while in menu...
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private static bool ContinueOnKeyPressed(int index)
        {
            // index == 0 is equal to "cancel application"
            if (0 == index)
            {
                return false;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n        Tryck tangent för att fortsätta      ");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
            return true;
        }

        private static void FormatHead()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void CreateShapeAndView(ShapeType shapeType)
        {
            Console.Clear();
            shape = CreateShape(shapeType);
            ViewShapeDetail(shape);
        }    
    } 
 } 

