﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L3C
{


         enum ShapeType { Indefinite, Rectangle, Circle, Ellipse, Cuboid, Cylinder, Sphere, }; 

    class Program
    {
        static void Main(string[] args)
        {

               bool exit = false; 
              ShapeType type = ShapeType.Indefinite; 
 
 
             do 
             { 
                 switch (GetMenuChoice()) 
                 { 
                     case 0: 
                         exit = true; 
                         continue; 
 
 
                     case 1: 
                         type = ShapeType.Rectangle; 
                         break; 
 
                     case 2: 
                         type = ShapeType.Circle; 
                         break; 
 
                     case 3: 
                         type = ShapeType.Ellipse; 
                         break;
 
                     case 4: 
                         type = ShapeType.Cuboid; 
                         break; 

                     case 5: 
                         type = ShapeType.Cylinder; 
                         break; 

                     case 6: 
                         type = ShapeType.Sphere; 
                         break; 


 
                     default: 
                         Debug.Assert(false, "Hantering av menyalternativet saknas."); 
                         continue; 
 
                 } 
 
 
                 Console.Clear(); 
                 INoise noise = CreateNoiseObject(type); 
                 noise.MakeNoise(); 
                 ContinueOnKeyPressed(); 
             } while (!exit); 
         } 
 
 
         /// <summary> 
         /// Meddelar användaren att trycka på vilken tangent som helst 
         /// för att forsätta exekveringen av programmet. 
         /// </summary> 
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
 
 
         /// <summary> 
         /// Skapar ett objekt som implementerar interfacet INoise och som 
         /// därmed kan för lite oljud. 
         /// </summary> 
         /// <param name="type">Värdet som bestämmer vilken type av objekt som ska skapas.</param> 
         /// <returns>En referens till det nyligen skapade objektet.</returns> 
        private static INoise CreateNoiseObject(ShapeType type) 
         { 
             switch (type) 
             { 
                 case ShapeType.Car: 
                     return new Car(); 
 
                 case ShapeType.Cat: 
                     return new Cat(); 
 
                 case ShapeType.Dog: 
                     return new Dog(); 
 
                 default: 
                     throw new NotImplementedException(); 
             } 
         } 
 
         private static int GetMenuChoice() 
         { 
             int index; 
 
             do 
             { 
                 Console.Clear(); 
                 Console.BackgroundColor = ConsoleColor.DarkCyan; 
                 Console.ForegroundColor = ConsoleColor.White; 
                 Console.WriteLine(" ╔═══════════════════════════════════╗ "); 
                 Console.WriteLine(" ║         Geometriska figurer       ║ "); 
                 Console.WriteLine(" ╚═══════════════════════════════════╝ "); 
                 Console.BackgroundColor = ConsoleColor.Black;  
                 Console.WriteLine(" 0. Avsluta.");  
                 Console.WriteLine(" 1. Rectangle."); 
                 Console.WriteLine(" 2. Circle."); 
                 Console.WriteLine(" 3. Ellipse.");
                 Console.WriteLine(" 4. Cuboid");
                 Console.WriteLine(" 5. Cylinder");
                 Console.WriteLine(" 6. Sphere");
                 Console.WriteLine(" 7. Slumpa 2D-figurer");
                 Console.WriteLine(" 8. Slumpa 3D-figurer");
                 Console.WriteLine("\n ═══════════════════════════════════════════\n"); 
                 Console.Write(" Ange menyval [0-8]: "); 
                 Console.ResetColor(); 
 
 
                 // Läser in en sträng som försöker tolkas till ett heltal; validerar sedan att 
                 // det inmatade heltalet är i det slutna intervallet mellan 0 och 4. 
                 if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 4) 
                 { 
                    return index; 
                 } 
 

                 Console.BackgroundColor = ConsoleColor.Red; 
                 Console.ForegroundColor = ConsoleColor.White; 
                 Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 8.\n"); 
                 ContinueOnKeyPressed(); 
             } while (true); 
         }      } 
 } 

        }
    }
}