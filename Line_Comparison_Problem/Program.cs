using System;

namespace Line_Comparison_Problem
{
    class Program
    {

        int xPoint1;
        int yPoint1;
        int xPoint2;
        int yPoint2;
        double length;

        public Program()
        {
            Console.WriteLine("Enter the coordinates of Line (x1,y1,x2,y2): ");
            this.xPoint1 = int.Parse(Console.ReadLine());
            this.yPoint1 = int.Parse(Console.ReadLine());
            this.xPoint2 = int.Parse(Console.ReadLine());
            this.yPoint2 = int.Parse(Console.ReadLine());
            this.length = 0;
        }

        // Fuction to find the length of the lines
        public double findLength()
        {
            this.length = Math.Sqrt(Math.Pow(this.xPoint2 - this.xPoint1, 2) + Math.Pow(this.yPoint2 - this.yPoint1, 2));
            return this.length;
        }
        //Function to find equality of 2 lengths
        public static void checkEquality(string length1, string length2)
        {
            if (length1.Equals(length2))
            {
                Console.WriteLine("The Lines are at equal length: " + length1);
            }
            else
            {
                Console.WriteLine("The Lines are not at equal length: L1: " + length1 + " L2: " + length2);
            }
        }

        //Function to compare the length of 2 lines

        public static void comparingTheLines(string length1, string length2)
        {
            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The Line1 with length " + length1 + " is greater than Line2 with length " + length2);
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The Line2 with length " + length2 + " is greater than Line1 with length " + length1);
            }
            else
            {
                Program.checkEquality(length1, length2);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            Program program = new Program();
            Program program1 = new Program();
            double length1 = program.findLength();
            double length2 = program1.findLength();
            while (true)
            {
                Console.WriteLine("Enter 0 to check equality / Enter 1 to compare Lines/ Enter 2 to Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Program.checkEquality(length1.ToString(), length2.ToString());
                        break;
                    case 1:
                        Program.comparingTheLines(length1.ToString(), length2.ToString());
                        break;
                    case 2:
                        return;
                    default:
                        break;

                }
            }
        }
    }
}

