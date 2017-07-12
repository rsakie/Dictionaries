using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // syntax for dictionary

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1","Twix" },
            //    {"A2", "Twizzler" },
            //    {"A3", "Reeses" },
            //    {"A4","Sour Patch Kids"}

            //};
            //foreach (KeyValuePair<string,string>item in snackMachine)
            //{
            //   // Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            ////using add method to add drinks
            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");
            ////counting the number of entries in the dictionary
            //// Console.WriteLine(drinkMachine.Count);

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //   // Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //create a dictionary for a theater coat check 10 elements
            //the key will be a number and value will be the coat style
            //print all the elements to the console
            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();


            //coatCheck.Add(1, "Winter");
            //coatCheck.Add(2, "Summer");
            //coatCheck.Add(3, "Spring");
            //coatCheck.Add(4, "Tremch");
            //coatCheck.Add(5, "Rain");
            //coatCheck.Add(6, "Sport");
            //coatCheck.Add(7, "None");
            //coatCheck.Add(8, "Sleeveless");
            //coatCheck.Add(9, "Patch Pocket");
            //coatCheck.Add(10, "Lapel");

            //foreach (KeyValuePair<int, string> item in coatCheck)
            //{
            //    Console.WriteLine(item);
            //}

            //car valet with 10 cars the key will be a customers last name and the
            //value will be the car make. print all the elements to the console

            //Dictionary<string, string> Valet = new Dictionary<string, string>()
            //{
            //    {"Sakie", "Dodge" },
            //    {"Kissane", "Chevy" },
            //    {"Lonjak", "Ford" },
            //    {"Johnson", "Kia" },
            //    {"Ruff", "Mazda" },
            //    {"Sum", "Mercedes" },
            //    {"Smith","Chevy" },
            //    {"Jordan","Subaru" },
            //    {"Daniels","Jeep" },
            //    {"Cintron","Jaguar" }
            //};
            //foreach (KeyValuePair<string, string> car in Valet)
            //{
            //    Console.WriteLine(car);
            //}

            //creat a dictionary of 10 zoo animals the key will be the animal type
            //the value will be the number of animals
            //print the animal with the highest quantity to the console
            //remove the zoo animalwith the lowest count

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();

            zooAnimals.Add("Elephant", 1);
            zooAnimals.Add("Camel", 2);
            zooAnimals.Add("Wolf", 3);
            zooAnimals.Add("Shark", 4);
            zooAnimals.Add("Polar Bear", 5);
            zooAnimals.Add("Flamingo", 6);
            zooAnimals.Add("Hippo", 7);
            zooAnimals.Add("Lion", 8);
            zooAnimals.Add("Tiger", 9);
            zooAnimals.Add("Bear", 10);

            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                Console.WriteLine("Key: {0}, Value {1}", zooAnimals.Key, zooAnimals.Value);
                Console.WriteLine(animal.Last);
            }
        }
    }
}
