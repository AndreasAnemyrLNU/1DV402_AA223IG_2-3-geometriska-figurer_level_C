using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{



    class Program
    {
        static void Main(string[] args)
        {


            private Shape CreateShape(ShapeType shapeType)
            {
                throw new NotImplementedException();
            }





            Sphere test = new Sphere(29.6);

            Console.WriteLine(test);

            Console.Read();








            //bool exit = false;
            //ShapeType type = ShapeType.Indefinite;

            //do
            //{
            //    switch (GetMenuChoice())
            //    {
            //        case 0:
            //            exit = true;
            //            continue;

            //        case 1:
            //            type = ShapeType.Rectangle;
            //            break;

            //        case 2:
            //            type = ShapeType.Circle;
            //            break;

            //        case 3:
            //            type = ShapeType.Ellipse;
            //            break;

            //        case 4:
            //            type = ShapeType.Cuboid;
            //            break;

            //        case 5:
            //            type = ShapeType.Cylinder;
            //            break;

            //        case 6:
            //            type = ShapeType.Sphere;
            //            break;
            //    }

            //    Console.Clear();
            //    INoise noise = CreateNoiseObject(type);
            //    noise.MakeNoise();
            //    ContinueOnKeyPressed();
            //} while (!exit);



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

//         private static int GetMenuChoice() 
//         { 
//             int index; 
 
//             do 
//             { 
//                 Console.Clear(); 
//                 Console.BackgroundColor = ConsoleColor.DarkCyan; 
//                 Console.ForegroundColor = ConsoleColor.White; 
//                 Console.WriteLine(" ╔═══════════════════════════════════╗ "); 
//                 Console.WriteLine(" ║         Geometriska figurer       ║ "); 
//                 Console.WriteLine(" ╚═══════════════════════════════════╝ "); 
//                 Console.BackgroundColor = ConsoleColor.Black;  
//                 Console.WriteLine(" 0. Avsluta.");  
//                 Console.WriteLine(" 1. Rectangle."); 
//                 Console.WriteLine(" 2. Circle."); 
//                 Console.WriteLine(" 3. Ellipse.");
//                 Console.WriteLine(" 4. Cuboid");
//                 Console.WriteLine(" 5. Cylinder");
//                 Console.WriteLine(" 6. Sphere");
//                 Console.WriteLine(" 7. Slumpa 2D-figurer");
//                 Console.WriteLine(" 8. Slumpa 3D-figurer");
//                 Console.WriteLine("\n ═══════════════════════════════════════════\n"); 
//                 Console.Write(" Ange menyval [0-8]: "); 
//                 Console.ResetColor(); 
 
//                 // Läser in en sträng som försöker tolkas till ett heltal; validerar sedan att 
//                 // det inmatade heltalet är i det slutna intervallet mellan 0 och 8. 
//                 if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 8) 
//                 { 
//                    return index; 
//                 } 
//                 Console.BackgroundColor = ConsoleColor.Red; 
//                 Console.ForegroundColor = ConsoleColor.White; 
//                 Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 8.\n"); 
//                 ContinueOnKeyPressed(); 
//                } while (true); 

//         }      
    } 
 } 

