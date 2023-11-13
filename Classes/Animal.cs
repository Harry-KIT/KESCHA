
namespace KESCHA.Classes
{
    
    class Animal
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string Food {get; set;}
        public string Country {get; set;}
        public double Weight {get; set;}
        public double Height {get; set;}

        // Default constructor
        public Animal()
        {
            // Initialization logic for default values
            Name = "Unknown";
            Age = 0;
            Food = "Unknown";
            Country = "Unknown";
            Weight = 0.0;
            Height = 0.0;
        }

        // Parameterized constructor with name and age
        public Animal(string name, int age)
        {
            // Initialization logic with provided values
            Name = name;
            Age = age;
            Food = "Unknown";
            Country = "Unknown";
            Weight = 0.0;
            Height = 0.0;
        }

        // Parameterized constructor with full details
        public Animal(string name, int age, string food, string country, double weight, double height)
        {
            // Initialization logic with provided values
            Name = name;
            Age = age;
            Food = food;
            Country = country;
            Weight = weight;
            Height = height;
        }

        // Method to print details of the person
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Job: {Food}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");

            // Call the private method CalculateBMI from within the class
            double bmi = CalculateBMI();
            Console.WriteLine($"BMI: {bmi}");
        }

        // Private method to calculate BMI
        private double CalculateBMI()
        {
            // BMI formula: weight (kg) / (height (m))^2
            double heightInMeters = Height / 100.0;
            return Weight / (heightInMeters * heightInMeters);
        }


    }

}
