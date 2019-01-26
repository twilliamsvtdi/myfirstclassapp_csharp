using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an object of type human
            Human human1 = new Human();
            
            //Populating object with values 
            Console.Write("Enter First Name: ");
            human1.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            human1.LastName = Console.ReadLine();

            //Short method of accepting input and parsing
            Console.Write("Enter Age: ");
            human1.Age = int.Parse(Console.ReadLine());

            //Longer method of accepting input and then parsing
            Console.Write("Enter Height (metres): ");
            string height = Console.ReadLine();
            human1.Height = double.Parse(height);

            //Back to the shorter method
            Console.Write("Enter Weight (lbs): ");
            human1.Weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Hair Colour: ");
            human1.HairColour = Console.ReadLine();

            Console.WriteLine("Full Name: " + human1.FirstName + " " 
                + human1.LastName);
            // Console.WriteLine("Full Name: " + human1.FullName);
            Console.WriteLine($"You are {human1.FullName} and your age is " +
                $"{human1.Age} and you have {human1.HairColour} hair. ");
            Console.WriteLine($"You weigh {human1.Weight} lbs and stand at " +
                $"{human1.Height} metres tall.");

            //Declaring an object of type human, using non-default
            // constructor
            Human Eve = new Human("Eve", "Le'Chaim");
            Console.WriteLine(Eve.FullName);

            //Like System Pause
            Console.ReadLine();
        }
    }
}
