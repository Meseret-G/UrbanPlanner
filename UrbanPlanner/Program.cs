using System;
using UrbanPlanner.Models;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate - use the 'new' keyword to create an instance of an object 
            // initialize - give an instance an intial value 
            Building oneTwoThree = new Building("123 main street");

            oneTwoThree.Width = 5;
            oneTwoThree.Stories = 2;
            oneTwoThree.Depth = 10;

            Building fourFiveSix = new Building("456 main street")
            {
                Width = 7,
                Depth = 4,
                Stories = 3
        };
            Building differentOne = new Building("1023 main street")
            {
                Width = 6,
                Depth = 15,
                Stories = 1
            };
            Building shertLocksPlace = new Building("221B Baker street")
            {
                Width = 7,
                Depth = 14,
                Stories = 2
            };
            oneTwoThree.Construct();
            fourFiveSix.Construct();
            shertLocksPlace.Construct();

            oneTwoThree.Purchase(" Scrooge");
            //@ - string verbatim 
            oneTwoThree.PrintToConsole();

            fourFiveSix.Purchase(" Myself");
            fourFiveSix.PrintToConsole();

            shertLocksPlace.Purchase(" Myself");
            shertLocksPlace.PrintToConsole();



        }
    }
}
