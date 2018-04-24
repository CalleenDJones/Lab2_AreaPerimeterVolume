using System;

namespace Lab2_AreaPerimeterVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double Length;
            double Width;
            double Height;
            double Area;
            double Perimeter;
            double Volume;
             
            String GamePlay;

            //Introduce user to the purpose of information being requested
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! ");
           
            //Request room dimensions
            Console.WriteLine("Please enter the length of a wall in the room");
            Length = Double.Parse(Console.ReadLine());

            if (Length < 0)
            {
                Console.WriteLine("Invalid. Please try again with a positive number");
                Console.WriteLine("Please enter the length of a wall in the room");
                Length = Double.Parse(Console.ReadLine());
            }//end verification of positive numbers ONLY

            else
            {
                Console.WriteLine("Please enter the width of a wall in the room");
                Width = Double.Parse(Console.ReadLine());
            
                if (Width < 0)
                {
                    Console.WriteLine("Invalid. Please try again with a positive number");
                    Console.WriteLine("Please enter the width of a wall in the room");
                    Width = Double.Parse(Console.ReadLine());
                }//end verification of positive numbers ONLY

                //Calculations on user input for Area and Perimeter
                Area = (Length * Width);
                Console.WriteLine("The Area of the Room is: " + Area);

                Perimeter = (Length * Width) * 2;
                Console.WriteLine("The Perimeter of the Room is: " + Perimeter);
            }

            Console.WriteLine("Would you like to continue inorder to calulate the volume of the room?");
            Console.Write("Please enter yes or no only.");
            GamePlay = (Console.ReadLine());

            if (GamePlay == "yes")
            {
                Console.WriteLine("Please enter the width of a wall in the room");
                Width = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Height of a wall in the room");
                Height = Double.Parse(Console.ReadLine());
                Volume = (Length * Width * Height);

                Area = (Length * Width);
                Perimeter = (Length * Width) * 2;

                Console.WriteLine("The Area of the Room is: " + Area);
                Console.WriteLine("The Perimeter of the Room is: " + Perimeter);
                Console.WriteLine("The Volume of the Room is: " + Volume);
            }
            else if (GamePlay == "no")
            {
                Console.WriteLine("Thank you. Exiting.");
                return;
            }
            Console.ReadKey();
        }   
    }
}
