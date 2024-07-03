using System;
using System.Diagnostics;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;

            while((command = Console.ReadLine()) != "Beast!") 
            {
                string animalType = command;
                string[] tockens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new(tockens[0], int.Parse(tockens[1]), tockens[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                            Cat cat = new(tockens[0], int.Parse(tockens[1]), tockens[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Frog":
                            Frog frog = new(tockens[0], int.Parse(tockens[1]), tockens[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new(tockens[0], int.Parse(tockens[1]));
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new(tockens[0], int.Parse(tockens[1]));
                            Console.WriteLine(tomcat);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
            }  
        }
    }
}
