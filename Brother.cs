using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeClasses
{
    internal class Brother
    {       //This class is named after the names of a printer.
            //Made it so I could keep Main clean.
        public static void Outputter()
        {
            //Circles
            Circle input1 = new();
            input1.radius = 5;
            Console.WriteLine($"A Cirkel radius of {input1.radius} has the area of: {input1.getArea():F2}\n");
            //:F2 makes the output to keep to 2 decimals.

            Circle input2 = new();
            input2.radius = 6;
            Console.WriteLine($"A Cirkel radius of {input2.radius} has the area of: {input2.getArea():F2}\n");

            //Spheres
            Sphere Boll1 = new();
            Boll1.radius = 5;
            Console.WriteLine($"A spehere with the radius of {Boll1.radius} has the volume of: {Boll1.getVol():F2}\n");

            Sphere Boll2 = new();
            Boll2.radius = 6;
            Console.WriteLine($"A spehere with the radius of {Boll2.radius} has the volume of: {Boll2.getVol():F2} \n");

            //Triangles
            Triangle Tri1 = new();
            Tri1.height = 10;
            Tri1._base = 5;
            Console.WriteLine($"A Triangle with the height of {Tri1.height} and base of {Tri1._base} has the area of: {Tri1.getTriArea():F2} \n");
            
            Triangle Tri2 = new();
            Tri2.height = 7;
            Tri2._base = 2;
            Console.WriteLine($"A Triangle with the height of {Tri2.height} and base of {Tri2._base} has the area of: {Tri2.getTriArea():F2}\n");
        }
    }
}
