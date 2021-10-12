using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>
        {
            new Movie ("Soul", "Animated"),
            new Movie ("Up", "Animated"),
            new Movie ("Lighthouse", "Drama"),
            new Movie ("Silver Lining Playbook", "Drama"),
            new Movie ("It", "Horror"),
            new Movie ("Saw", "Horror"),
            new Movie ("Blade", "SciFi"),
            new Movie ("Underworld", "SciFi"),
            new Movie ("Star Wars", "SciFi"),
            new Movie ("Cloudy With A Chance Of Meatballs", "Animated")
        };
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.");
            bool runProgram = true;
            while (runProgram)
            {
                showMovies(Movies);
                runProgram = getContinue();
            }
        }

        public static void showMovies(List<Movie> Movies)
        {
            List<Movie> selectedGenre = new List<Movie> { };
            bool correctInput = false;
            while (correctInput == false)
            {
                Console.WriteLine("Please enter a genre: Animated, Horror, Drama, SciFi");
                string choice = Console.ReadLine().ToLower().Trim();
                foreach (Movie m in Movies)
                {
                    if (choice == m.GetCategory().ToLower().Trim())
                    {
                        selectedGenre.Add(m);
                        correctInput = true;
                    }
                }
                if (correctInput == false)
                {
                    Console.WriteLine("That was not a valid input.");
                }
                foreach (Movie m in selectedGenre)
                {
                  
                    Console.WriteLine(m.GetTitle());
                }
            }

        }
        public static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                }
            }

            return result;
        }
    }
}
