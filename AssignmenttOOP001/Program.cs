using System.ComponentModel;

namespace AssignmenttOOP001
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,

    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Permissions
    {
        Read = 1, 
        Write = 2, 
        Delete = 4, 
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    internal class Program
    {
        static double CalculateDistance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static void Main(string[] args)
        {

            #region Question01

            //1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday) 
            //as its members.Then, write a C# program that prints out all the days of the week using this enum.

            /*foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
            Console.WriteLine(day);
            }*/


            #endregion

            #region Question02
            //2.Create an enum called "Season" with the four seasons
            //(Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user
            //and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            /*Console.Write("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season.");
            }*/
            #endregion

            #region Question03
            /*
             3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                Create Variable from previous Enum to Add and Remove Permission from variable,
                check if specific Permission is existed inside variable
             */

            /*Permissions permissions = Permissions.Read;
            Console.WriteLine(permissions); //
            Console.WriteLine("=============After Adding Write=================");
            permissions = permissions ^ Permissions.Write;
            Console.WriteLine(permissions);
            Console.WriteLine("============After Adding Execute==================");
            permissions = permissions ^ Permissions.Execute;
            Console.WriteLine(permissions);
            Console.WriteLine("============After Delete Write==================");
            permissions = permissions ^ Permissions.Write;
            Console.WriteLine(permissions);
            Console.WriteLine("============After Delete Execute==================");
            permissions = permissions ^ Permissions.Execute;
            Console.WriteLine(permissions);
            Console.WriteLine("============ Checking==================");
            // check if permission exist or not
            if ((permissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read Is Existed");
            }
            else
            {
                Console.WriteLine("Read Is Not Existed");
            }*/
            #endregion

            #region Question04
            /*
             Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            Write a C# program that takes a color name as input from the user and displays a message
            indicating whether the input color is a primary color or not
             */

            /*Console.Write("Enter a color: ");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Colors color))
            {
                Console.WriteLine($"{input} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{input} Not a primary color.");
            }*/


            #endregion

            #region Question05

            /*Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
             * Write a C# program that takes two points as input from the user and 
             * calculates the distance between them.*/

            /*Console.Write("Enter the X coordinate of the first point:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Y coordinate of the first point:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Point point1 = new Point(x1, y1);

            Console.Write("Enter the X coordinate of the second point:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Y coordinate of the second point:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Point point2 = new Point(x2, y2);

            double distance = CalculateDistance(point1, point2);
            Console.WriteLine($"The distance between the two points is: {distance}");*/

            #endregion



        }
    }
}
