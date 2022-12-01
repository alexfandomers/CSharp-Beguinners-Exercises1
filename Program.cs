namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
            //If the user enters a valid number, display "Valid" on the console. 
            //Otherwise, display "Invalid".
            Console.WriteLine("/////Exercise 1/////");
            Console.WriteLine("Input a number between 1 to 10: ");
            var input =Convert.ToInt32(Console.ReadLine());

            if (input >=1 && input <=10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine("/////Exercise 2/////");
            //2- Write a program which takes an array of numbers and displays both the value and the index of the largest value.
            var numbers = new [] {2,9,10,14,7,3};
            int m = numbers.Max();
            int p = Array.IndexOf(numbers, m);           
            
            Console.WriteLine("{0} {1}", m, p);

            Console.WriteLine("/////Exercise 3/////");
            //3- Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Input first number number: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("the maximun value is: "+ a);
            }
            else if(a < b)
            {
                Console.WriteLine("the maximun value is: "+ b);
            }
            else
            {
                Console.WriteLine("Same value inputs");
            }

            Console.WriteLine("/////Exercise 4/////");
            //3- Write a program and ask the user to enter the width and height of an image. 
            //Then tell if the image is landscape or portrait. 
            Console.WriteLine("Input the img width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the img height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("Its a landscape");
            }
            else
            {
                Console.WriteLine("Its a portrait");
            }

            Console.WriteLine("/////Exercise 5/////");
            //4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera,
            //sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit.
            //Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
            //program should display Ok on the console. If the value is above the speed limit, 
            //the program should calculate the number of demerit points. 
            //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            //If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Enter car speed: ");
            var speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed limit: ");
            var limit = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
               const int kmPerSpeedLimit = 5;
               var demerit = (speed - limit) / kmPerSpeedLimit;

               if (demerit > 12)
               {
                 Console.WriteLine("License suspended");
               }
               else{
                Console.WriteLine("Demerit points: " + demerit);
               }
            }

        }
    }
}
