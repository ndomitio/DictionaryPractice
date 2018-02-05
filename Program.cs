using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////dictionary example

            //////syntax
            ////// "the word dictionary" <data type for key, date type for value> name of dictionary
            ////// new implies "instantiation" 
            ////Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            ////{
            ////    {"Kerry", 90 }, //"Kerry is the key, 90 is the value
            ////    {"Berry", 85 },
            ////    {"Michelle", 100 }
            ////};

            //////vending machine  placement code  is unique to each position, but there could be the same snack at multiple  spots

            ////Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            ////{
            ////    {"A1", "Snickers" },
            ////    {"A2", "Swedish Fish" },
            ////    {"A3", "Sour Patch Kids" },
            ////    {"A4", "Funyuns" }
            ////};


            //////different way from slides

            ////Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            ////// semi colon imples empty dictionary
            //////using the add method, lets add drinks to our drink machine
            //////this machine uses just a number to vend the item
            //////dictionaries, like list are mutable...they can grow and shrink...no set value
            //////technically they are zero indexed, but they are usually referred to by the corresponding "key"


            ////drinkMachine.Add(10, "Ginger Ale");
            ////drinkMachine.Add(11, "Pepsi");
            ////drinkMachine.Add(12, "Coke");
            ////drinkMachine.Add(7, "7-Up");
            ////drinkMachine.Add(8, "Mountain Dew");
            ////drinkMachine.Add(6, "Sprite");


            //////count is a property, not a method. Returns the size of the dictionary.  
            ////Console.WriteLine(drinkMachine.Count);

            //////We have another property, called .Key 
            ////foreach(KeyValuePair<int, string> drink in drinkMachine)
            ////{
            ////    Console.WriteLine(drink.Key);
            ////}

            ////foreach(KeyValuePair<int, string> drink in drinkMachine)///drink is a "Local" variable, only belongs to the  loop it is in.s
            ////{
            ////    Console.WriteLine(drink.Value);
            ////}


            ////create a dictionary for a theatre coat check...key is number value is a coat style

            ////Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            ////{
            ////    {1, "track jacket" },
            ////    {2, "pea coat" },
            ////    {3, "suit coat" },
            ////    {4, "blazer" },
            ////    {5, "winter coat" },
            ////    {6, "overcoat" },
            ////    {7, "rain jacket" },
            ////    {8, "windbreaker" },
            ////    {9, "black coat" },
            ////    {10, "blue coat" },
            ////};
            ////foreach(KeyValuePair<int, string>coat in coatCheck)
            ////{
            ////    Console.WriteLine(coat.Key);
            ////    Console.WriteLine(coat.Value);

            ////}

            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Johnson", "ford" },
            //    {"Davis", "dodge" },
            //    {"Sales", "tesla" },
            //    {"Weis", "VW" },
            //    {"Lewis", "BMW" },
            //    {"Rambo", "Audi" },
            //    {"Gonzalez", "Porsche" },
            //    {"Chen", "Lambo" },
            //    {"West", "Chevy" },
            //    {"Smith", "Kia" },
            //};
            //foreach (KeyValuePair<string, string> car in carValet)
            //{
            //    Console.WriteLine(car.Key);
            //    Console.WriteLine(car.Value);
            //}

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"penguin", 5 },
                { "elephant", 4},
                { "ostrich", 3},
                {"emu", 7 },
                {"giraffe",6 },
                { "koala", 4},
                { "iguana", 2},
                { "deer", 9},
                { "cheetah", 6},
                { "lions", 50}
            };

            int highest = 0;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }


            //how to isolate and print the largest amount of animals at the zoo
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Value);
                    Console.WriteLine(animal.Key);
                }


            }



            //slide 2 from lesson on dictionaries, last slide for sample problems.




        }
    }
}
