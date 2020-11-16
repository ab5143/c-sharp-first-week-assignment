using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            //string means type, firstName is the "Variable", = assignment opeatror, Atif is the value of the container 
            string fistName = "Atif";
            string lastName = "Baloch";
            int age = 46;

            //arrays only hold a fixed amount of values, collections in c sharp always always start at index zero
            //arrays contains lengths
            string[] favoriteMovies = new string[4];

            favoriteMovies[0] = "The long walk home.";
            favoriteMovies[1] = "The second long walk home.";
            favoriteMovies[2] = "The Terminator";
            favoriteMovies[3] = "Little Mermaid";

            for (int i = 0; i < favoriteMovies.Length; i++)
            {
                Console.WriteLine(favoriteMovies[i]);
            }

            Console.WriteLine($"The length value of favoriteMovies is {favoriteMovies.Length}");

            List<DateTime> dates = new List<DateTime>();
            dates.Add(new DateTime(2020, 11, 15));
            dates.Add(new DateTime(2020, 12, 17));
            dates.Add(DateTime.Now);
            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine(dates[i]);
            }
            int modAge = age + 7;
            Console.WriteLine($"This age is 46+7= {modAge}");

            int hoursOfSleep = 10;


            if (hoursOfSleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            // assignment opperators , ==, !=, && , ||
            /*
            else if (hoursOfSleep > 8 && hoursOfSleep < 10) )
            {
                    Console.WriteLine("You should be pretty rested.");
                
            }*/
            else if (hoursOfSleep > 8)
            {
                if (hoursOfSleep < 10)
                {
                    Console.WriteLine("You should be pretty rested.");
                }

            }
            else if (hoursOfSleep > 4)
            {
                if (hoursOfSleep <8)
                {
                    Console.WriteLine("Bummer!");
                }
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            string emotion = Console.ReadLine();

            switch (emotion)
            {
                case "Great":
                    Console.WriteLine("I am having a great day");
                    break;
                case "Good":
                    Console.WriteLine("I am having a good day");
                    break;
                case "Okay":
                   Console.WriteLine("Okay");
                    break;
                case "Bad":
                    Console.WriteLine("I am having a bad day");
                    break;
                default:
                    Console.WriteLine("How are you feeling today");
                    break;
                    
            }








            //CW TAB TAB
            Console.WriteLine(fistName);

            Console.ReadKey();
        }
    }
}
