namespace TownShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string buy = Console.ReadLine();
            string city = Console.ReadLine();
            double how = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":

                    if (buy == "coffee")
                    {
                        how *= 0.50;
                        Console.WriteLine(how);
                    }
                    else if (buy == "water")
                    {
                        how *= 0.80;
                        Console.WriteLine(how);
                    }
                    else if (buy == "juice")
                    {
                        how *= 1.20;
                        Console.WriteLine(how);
                    }
                    else if (buy == "sweets")
                    {
                        how *= 1.45;
                        Console.WriteLine(how);
                    }
                    else if (buy == "peanuts")
                    {
                        how *= 1.60;
                        Console.WriteLine(how);
                    }
                    break;
                case "Plovdiv":

                    if (buy == "coffee")
                    {
                        how *= 0.40;
                        Console.WriteLine(how);
                    }
                    else if (buy == "water")
                    {
                        how *= 0.70;
                        Console.WriteLine(how);
                    }
                    else if (buy == "juice")
                    {
                        how *= 1.15;
                        Console.WriteLine(how);
                    }
                    else if (buy == "sweets")
                    {
                        how *= 1.30;
                        Console.WriteLine(how);
                    }
                    else if (buy == "peanuts")
                    {
                        how *= 1.50;
                        Console.WriteLine(how);
                    }
                    break;
                case "Varna":

                    if (buy == "coffee")
                    {
                        how *= 0.45;
                        Console.WriteLine(how);
                    }
                    else if (buy == "water")
                    {
                        how *= 0.70;
                        Console.WriteLine(how);
                    }
                    else if (buy == "juice")
                    {
                        how *= 1.10;
                        Console.WriteLine(how);
                    }
                    else if (buy == "sweets")
                    {
                        how *= 1.35;
                        Console.WriteLine(how);
                    }
                    else if (buy == "peanuts")
                    {
                        how *= 1.55;
                        Console.WriteLine(how);
                    }
                    break;
            }
        }
    }
}