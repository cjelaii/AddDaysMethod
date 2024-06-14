using System;

namespace AddDaysMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingDay = GetDayNumber();
            int daysToAdd = GetDaysToAdd();
            int finalDay = CalculateFinalDay(startingDay, daysToAdd);

            PrintDay(finalDay);
        }

        static int GetDayNumber()
        {
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt16(Console.ReadLine());

            while (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Invalid Input. Please enter a number between 1 and 7:");
                dayNumber = Convert.ToInt16(Console.ReadLine());
            }

            return dayNumber;
        }
        static int GetDaysToAdd()

        {
            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt16(Console.ReadLine());
            return dayToAdd;
        }
        static int CalculateFinalDay(int startingDay, int daysToAdd)
        {
            int finalDay = (startingDay + daysToAdd) % 7;
            return finalDay == 0 ? 7 : finalDay;
        }

        static void PrintDay(int finalDay)
        {
            switch (finalDay)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }
}