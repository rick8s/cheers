using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name + ", " + "What's your birthday? (MM/DD)");
            DateTime dateAndTime = DateTime.Now;
            var start = dateAndTime.Date;
            string birthday = System.Console.ReadLine();
            DateTime end = DateTime.Parse(birthday);
            int difference = (start - end).Days;
            System.Console.WriteLine("start: " + start + " end: "+ end+ "  difference: " + difference);

            foreach (char letter in name.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    string choose = "a";
                    foreach (char annies in "aefhilmnorsx")
                    {
                        if (letter == annies)
                        {
                            choose = "an";
                        }
                    }
                    System.Console.WriteLine("Give me " + choose + "..." + letter);
                }
            }
            System.Console.WriteLine(name.ToUpper() + "'s just GRAND!" + "\n");
            if (difference < 0)
            { 
                int remainingDays = 0 - difference;
                if (remainingDays < 2)
                {
                    System.Console.WriteLine("Your birthday is " + remainingDays + " day away!");
                }
                else
                {
                    System.Console.WriteLine("Your birthday is " + remainingDays + " days away!");
                }
            }
            else if (difference == 0)
 
                {
                    System.Console.WriteLine("Happy Birthday!!");
                }
            else
            {
                int remainingDays = 365 - (difference);
                System.Console.WriteLine("I missed your birthday this year.\n" + "Now it's " + remainingDays + " days away!\n" + "Happy belated birthday though.");
            }
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
