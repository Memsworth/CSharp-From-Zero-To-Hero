using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            var userOne = GetUserInfo();
            Console.WriteLine($"{userOne}");

            var userTwo = GetUserInfo();
            Console.WriteLine($"{userTwo}");
        }

        public static string GetInput(string message)
        {
            Console.Write($"{message}");
            var input = Console.ReadLine();
            return input;
        }
        public static int GetInt(string message) => int.Parse(GetInput(message));
        public static float GetFloat(string message) => float.Parse(GetInput(message));
        public static float CalculateBMI(float weight, float height) => weight / (float)Math.Pow(height, 2);

        public static string GetUserInfo()
        {
            var name = GetInput("name: ");
            var surName = GetInput("surname: ");
            var age = GetInt("age: ");
            var weight = GetFloat("weight: ");
            var height = GetFloat("height: ");
            var bmi = CalculateBMI(weight, height);

            return PrintUserInfo(name, surName, age, weight, height);
        }

        public static string PrintUserInfo(string name, string sureName, int age, float weight, double height)
        {
            return $"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.";
        }
    }
}