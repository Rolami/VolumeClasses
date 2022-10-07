

namespace VolumeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle input1 = new();
            //System.Console.WriteLine(input1.getArea());
            input1.radius = 5;
            Console.WriteLine($"Cirkel area: {input1.getArea():F2}" );



            Circle input2 = new();
            input2.radius = 6;
            Console.WriteLine($"Cirkel area: {input2.getArea():F2}");

            Sphere boll1 = new();
            boll1.radius = 5;
            Console.WriteLine($"Sphere volume: {boll1.getVol():F2}");

            Sphere boll2 = new();
            boll2.radius = 6;
            Console.WriteLine($"Sphere volume: {boll2.getVol():F2}");
        }




    }
}
