using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{
    class Program
    {
        private static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║              Cirkel               ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                    break;

                case ShapeType.Cuboid:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║             Rätblock              ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                    break;

                case ShapeType.Cylinder:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║              Cylinder             ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                    break;

                case ShapeType.Ellipse:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║              Ellipse              ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                    break;

                case ShapeType.Rectangle:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║             Rektangel             ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                    break;

                case ShapeType.Sphere:
                    Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                    Console.WriteLine(" ║                Sfär               ║ ");
                    Console.WriteLine(" ╚═══════════════════════════════════╝ ");
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
        {
            throw new NotImplementedException();
        }

        private static Shape3D[] Randomize3DShape()
        {
            throw new NotImplementedException();
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
                if (double.Parse(dimensionsArr[i]) <= 0d)
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
                Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                Console.WriteLine(" ║         Geometriska figurer       ║ ");
                Console.WriteLine(" ╚═══════════════════════════════════╝ ");
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
                Console.WriteLine("\n ═══════════════════════════════════════════\n");
                Console.Write(" Ange menyval [0-8]: ");
                Console.ResetColor();
        }

        private static void ViewMenuErrorMessage()
        {
            throw new NotImplementedException();
        }

        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine(shape.ToString());
        }

        private static void ViewShapes(Shape[] shapes) 
        {
            foreach(Shape shape in shapes)
            {
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


            } while ((index == 0));


            Shape testarShape = CreateShape(shapeType);

            ViewShapeDetail(testarShape);





         //   Shape ellipse, rectangle;

       //     ellipse = CreateShape(ShapeType.Ellipse);
     //       rectangle = CreateShape(ShapeType.Rectangle);

    //        ViewShapeDetail(test);

      //      Shape[] shapeArr = { ellipse, rectangle };

    //        ViewShapes(shapeArr);


            Console.Read();





        }

 
//         private static void ContinueOnKeyPressed() 
//         { 
//             Console.ForegroundColor = ConsoleColor.White; 
//             Console.BackgroundColor = ConsoleColor.DarkBlue; 
//             Console.Write("\n   Tryck tangent för att fortsätta   "); 
//             Console.ResetColor(); 
//             Console.CursorVisible = false; 
//             Console.ReadKey(true); 
//             Console.Clear(); 
//             Console.CursorVisible = true; 
//         } 
//         /// <summary> 
//         /// Skapar ett objekt som implementerar interfacet INoise och som 
//         /// därmed kan för lite oljud. 
//         /// </summary> 
//         /// <param name="type">Värdet som bestämmer vilken type av objekt som ska skapas.</param> 
//         /// <returns>En referens till det nyligen skapade objektet.</returns> 
//         /// 
//        //Undrar om det går bra med shape typ här?
//         private static shape CreateShape(ShapeType type)
//         {
//             switch (type)
//             {
//                 case ShapeType.Rectangle:
//                     return new Rectangle();

//                 case ShapeType.Circle:
//                     return new Circle();

//                 case ShapeType.Ellipse:
//                     return new Ellipse();

//                 case ShapeType.Cuboid:
//                     return new Cuboid();

//                 case ShapeType.Cylinder:
//                     return new Cylinder();

//                 case ShapeType.Sphere:
//                     return new Sphere();

//// lägg till random cases 2d & 3d sedan!



//                 default:
//                     throw new NotImplementedException();
//             }
//         } 


      
    } 
 } 

