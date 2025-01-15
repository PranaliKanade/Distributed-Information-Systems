using System;

namespace Exercise_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            int height;

            int heartrate;
            age = 26;
            height = 126;
            heartrate = 220 - age;
            
            
            Console.WriteLine("I am "+age+" years old, my max heart rate is "+ heartrate+" I am "+height +" inches tall.");
        }
    }
}
