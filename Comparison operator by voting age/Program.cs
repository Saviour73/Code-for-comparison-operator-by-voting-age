using System;

namespace Comparison_operator_by_voting_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");

            int myage = 25;
            int votingage = 18;

            Console.WriteLine(myage >= votingage);

            if (myage >= votingage)
            {
                Console.WriteLine("old enough to vote");

            }
            else
            {
                Console.WriteLine("not old enough to vote");
            }


        }

    }
}

        