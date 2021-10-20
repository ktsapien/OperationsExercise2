using System;

namespace OperationsExercise2Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Allow user to input the radius
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());


            //Calculate area of the circle
            var areaOfCircle = CalculateArea(radius);


            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle} ");




        }
        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);

        }
     
    }
}
