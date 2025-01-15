using System;

namespace InClass_4
{
    //Contructors
    class Car
    {
        public string model;  // Create a field
        public string color;
        public int year;
        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }
        // Create a class constructor with a parameter
        public Car(string modelName)
        {
            model = modelName;
        }
        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model

            Car Ford2 = new Car("Mustang2");
            Console.WriteLine(Ford2.model);
            Car Ford3 = new Car("Mustang3", "Red", 1969);
            Console.WriteLine(Ford3.color + " " + Ford3.year + " " + Ford3.model);

            //Without constructor

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Opel.model);
        }
    }
}
