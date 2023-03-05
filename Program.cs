using System.Linq.Expressions;

namespace seasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounths = Console.ReadLine();

            switch(mounths)
            {
                case "january":
                case "february":
                case "december":
                    Console.WriteLine("Winter");
                    break;

                case "march":
                case "april":
                case "may":
                    Console.WriteLine("spring");
                    break;

                case "june":
                case "july":
                case "august":
                    Console.WriteLine("summer");
                    break;

                case "september":
                case "october":
                case "november":
                    Console.WriteLine("autumn");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}