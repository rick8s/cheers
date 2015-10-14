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
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in name)
                {
                string choose = "a";
                foreach(char annies in "aefhilmnorsxAEFHILMNORSX")
                    {
                        if (letter == annies)
                        {
                            choose = "an";
                        }   
                    }
                System.Console.WriteLine("Give me " + choose + " " + letter);
                }
            name = name.ToUpper();
            System.Console.WriteLine(name + "'s just GRAND!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
