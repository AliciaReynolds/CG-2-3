using System;

namespace CG_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coder Mad Libs!!");
            Console.WriteLine();
            Console.WriteLine("Please Type an Adjective.");
            string adjective = Console.ReadLine();

            Console.WriteLine("Please Type a Verb.");
            string verb = Console.ReadLine();

            Console.WriteLine("Please Type a Noun.");
            string noun = Console.ReadLine();

            Console.WriteLine("On " + adjective + " days I like to " + verb + " while I play my " + noun);
            Console.ReadLine();


        }
    }
}
