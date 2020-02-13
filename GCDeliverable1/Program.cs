using System;

namespace GCDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            int groupSize;
            string result;
            string vacationDestination = "";
            string travelMode = "";

            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventerous?");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());

            if (vacationType == "musical")
            {
                vacationDestination = "New Orleans";
            }

            else if (vacationType == "tropical")
            {
                vacationDestination = "a beach vacation in Mexico";
            }
            else if (vacationType == "adventerous")
            {
                vacationDestination = "do white water rafting in the Grand Canyon";
            }
            if (groupSize <= 2)
            {
                travelMode = "first class flight";
            }
            else if (groupSize <= 5)
            {
                travelMode = "helicopter";
            }
            else if (groupSize >= 6)
            {
                travelMode = "charter flight";
            }
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelMode + " to " + vacationDestination + ".";
            Console.WriteLine(result);
        }

    }
    }

