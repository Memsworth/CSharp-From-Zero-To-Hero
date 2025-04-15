using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson4
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

        public static string GetString(string message)
        {
            var input = GetInput(message);
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }
        public static int GetInt(string message)
        {
            var input = GetInput(message);
            var isValidNumber = int.TryParse(input, out var result);
            return isValidNumber ? result : PrintAndReturnNumberError($"\"{input}\" is not a valid number.");

        }
        public static float GetFloat(string message)
        {
            var input = GetInput(message);
            var isValidNumber = float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out var result);

            return isValidNumber ? result : PrintAndReturnNumberError($"\"{input}\" is not a valid number.");
        }

        public static int PrintAndReturnNumberError(string message)
        {
            Console.WriteLine($"{message}");
            return -1;
        }

        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason: ");
                if (height <= 0)
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                if (weight <= 0)
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }

            return weight / (float)Math.Pow(height, 2);
        }

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
