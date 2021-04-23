using System;
using System.Collections.Generic;

namespace P_Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new C# console application and solution.  You will create two new classes, make sure you spell things correctly (case matters!).  
            //You will create the classes and then you will have the user enter all of the information for the ToyBoxes and all of the Toys inside 
            //of each ToyBox in your Program.cs Main method.  Once the user is done inputting all of their Toys/ToyBoxes, output all the Toys for 
            //each ToyBox.  After you do that, output a random toy from each ToyBox.

            string answer;
            List<ToyBox> toyBoxes = new List<ToyBox>();
            Console.WriteLine("Would you like to make a new toy box? (yes or no)");
            answer = Console.ReadLine();

            while (answer.ToLower() == "yes")
            {
                ToyBox TB1 = new ToyBox();

                Console.WriteLine("Who is the owner of this toy box?");
                TB1.Owner = Console.ReadLine();

                Console.WriteLine("Where is this toy box located?");
                TB1.Location = Console.ReadLine();

                List<Toy> toys = new List<Toy>();
                Console.WriteLine("Would you like to add a toy to your toy box? (yes or no)");
                answer = Console.ReadLine();
                while (answer.ToLower() == "yes")
                {
                    Toy t1 = new Toy();

                    Console.WriteLine("Who is the manufacturer of the toy?");
                    t1.Manufacturer = Console.ReadLine();

                    Console.WriteLine("What is the name of the toy?");
                    t1.Name = Console.ReadLine();
            
                    Console.WriteLine("What is the price of the toy?");
                    double price;
                   
                    if (double.TryParse(Console.ReadLine(), out price) == false)
                    {
                        Console.WriteLine("Invalid answer! Goodbye!");
                        return;
                    }
                    t1.Price = price;

                    Console.WriteLine("What are the notes for this toy?");
                    t1.setNotes(Console.ReadLine());

                    toys.Add(t1);

                    Console.WriteLine("Would you like to add a toy to your toy box? (yes or no)");
                    answer = Console.ReadLine();

                }

                TB1.Toys = toys;

                Console.WriteLine("Would you like to make a new toy box? (yes or no)");
                answer = Console.ReadLine();

                toyBoxes.Add(TB1);
            }

            for (int i = 0; i < toyBoxes.Count; i++)
            {
                ToyBox currentToyBox = toyBoxes[i];
                Console.WriteLine($"Owner: {currentToyBox.Owner}, Location: {currentToyBox.Location}");

                Console.WriteLine($"Toys:");
                for (int j = 0; j < currentToyBox.Toys.Count ; j++)
                {
                    Toy currentToy = currentToyBox.Toys[j];
                    Console.WriteLine($"     - Manufacturer: {currentToy.Manufacturer}, Name: {currentToy.Name}, Price: {currentToy.Price.ToString("C")}, Notes: {currentToy.getNotes()}");
                }

                Console.WriteLine();
            }

        }
    }
}
