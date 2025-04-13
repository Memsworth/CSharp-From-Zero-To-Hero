using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            var sureName = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight: ");
            var weight = int.Parse(Console.ReadLine());
            Console.Write("Enter your height: ");
            var height = double.Parse(Console.ReadLine());

            var bmi = weight / (height / 100.0);

            Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Your BMI is: {bmi:2}");


            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            sureName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Enter your height: ");
            height = double.Parse(Console.ReadLine());

            bmi = weight / (height / 100.0);

            Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
        }
    }
}
