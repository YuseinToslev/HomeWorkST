namespace WorkTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            switch (d)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":

                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    break;

                case "Sunday":

               if (h >= 0)
                    {
                        Console.WriteLine("closed");
                    }
                    break;

            }

        }
    }
}