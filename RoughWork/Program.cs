using System;

namespace RoughWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annual = 15,
                sick = 30,
                family_responsibility = 3,
                remaining,
                requested;
            char choice;
  
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    Console.WriteLine("Enter the number of days requested: ");
                    requested = Convert.ToInt32(Console.ReadLine());
                    if (requested > annual)
                    {
                        Console.WriteLine("You have exceeded your annual leave");
                    }
                    else
                    {
                        remaining = annual - requested;
                        Console.WriteLine("You have {0} days remaining", remaining);
                    }
                    break;
                case 's':
                    Console.WriteLine("Enter the number of days requested: ");
                    requested = Convert.ToInt32(Console.ReadLine());
                    if (requested > sick)
                    {
                        Console.WriteLine("You have exceeded your annual leave");
                    }
                    else
                    {
                        remaining = sick - requested;
                        Console.WriteLine("You have {0} days remaining", remaining);
                    }
                    break;
                case 'f':
                    Console.WriteLine("Enter the number of days requested: ");
                    requested = Convert.ToInt32(Console.ReadLine());
                    if (requested > family_responsibility)
                    {
                        Console.WriteLine("You have exceeded your annual leave");
                    }
                    else
                    {
                        remaining = family_responsibility - requested;
                        Console.WriteLine("You have {0} days remaining", remaining);
                    }
                    break;
                default:
                    Console.WriteLine("You have entered something else");
                    break;
            }
        }
    }
}
