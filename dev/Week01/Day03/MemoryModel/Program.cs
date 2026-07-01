using MemoryModel;
using System;

namespace MemoryModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type (int)
            Console.WriteLine("Value Type (int)");

            int x = 10;
            int y = x;

            Console.WriteLine($"Before Change: x = {x}, y = {y}");

            y = 20;

            Console.WriteLine($"After Change : x = {x}, y = {y}");

            Console.WriteLine();

            // Reference Type (Array)

            Console.WriteLine("Reference Type (Array)");

            int[] numbers = { 10, 20, 30 };
            int[] copy = numbers;

            Console.WriteLine($"Before Change: numbers[0] = {numbers[0]}, copy[0] = {copy[0]}");

            copy[0] = 100;

            Console.WriteLine($"After Change : numbers[0] = {numbers[0]}, copy[0] = {copy[0]}");

            Console.WriteLine();

            // Struct (Value Type)

            Console.WriteLine("Struct");

            CoordinateStruct point1 = new CoordinateStruct();
            point1.X = 10;
            point1.Y = 20;

            CoordinateStruct point2 = point1;

            Console.WriteLine($"Before Change: point1 = ({point1.X},{point1.Y}), point2 = ({point2.X},{point2.Y})");

            point2.X = 100;

            Console.WriteLine($"After Change : point1 = ({point1.X},{point1.Y}), point2 = ({point2.X},{point2.Y})");

            Console.WriteLine();

            // Class (Reference Type)

            Console.WriteLine("Class");

            CoordinateClass pointA = new CoordinateClass();
            pointA.X = 10;
            pointA.Y = 20;

            CoordinateClass pointB = pointA;

            Console.WriteLine($"Before Change: pointA = ({pointA.X},{pointA.Y}), pointB = ({pointB.X},{pointB.Y})");

            pointB.X = 100;

            Console.WriteLine($"After Change : pointA = ({pointA.X},{pointA.Y}), pointB = ({pointB.X},{pointB.Y})");
        }
    }
}