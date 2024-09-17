using System;

namespace Part_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angle;
            Console.WriteLine("Im a compass tell me an angle and ill tell you where you are facing!");
            angle = Convert.ToInt32(Console.ReadLine());
            if (angle > 316)
            {
                Console.WriteLine("You're facing north!");
            }
            else if (angle > 224)
            {
                Console.WriteLine("You're facing west!");
            }
            else if (angle > 136)
            {
                Console.WriteLine("You're facing south!");
            }
            else if (angle > 45)
            {
                Console.WriteLine("You're facing east!");
            }
            else
            {
                Console.WriteLine("You're facing north!");
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            int time;
            Console.WriteLine("Welcome to the parking garage we charge $2.00 per hour how many minutes are you staying? ");
            
            time = Convert.ToInt32(Console.ReadLine());

            if ((time < 60))
            {
                Console.WriteLine("That will be be $4.00");
            }
            else if ((time < 120))
            {
                Console.WriteLine("$6.00 please!");
            }
            else if (((time < 180)))
            {
                Console.WriteLine("8.00 dabloons please!");
            }
            else if ((((time < 240))))
            {
                Console.WriteLine("10.00 bucks please!");
            }
            else if (((((time < 300)))))
            {
                Console.WriteLine("12.00 smackaroos please!");
            }
            else if (((time < 360)))
            {
                Console.WriteLine("14.00 bills please!");
            }
            else if (((time < 420)))
            {
                Console.WriteLine("16.00 clams please!");
            }
            else if (((time < 480)))
            {
                Console.WriteLine("18.00 moolah please!");
            }
            else if (((time < 540)))
            {
                Console.WriteLine("20.00 dollas please!");


            }
            else 
           { 
                Console.WriteLine("Still 20.00 Dollas");

            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            int speed;
            Console.WriteLine("How fast are the winds in your city?");
            speed = Convert.ToInt32(Console.ReadLine());
            switch (speed) 
            {
                case int n when (n <= 118):
                    Console.WriteLine("Thats just normal wind to me");
                    break;
                case int n when (n <= 153 && n >= 119):
                    Console.WriteLine("Thats a category 1 hurracane");
                    break;
                case int n when (n <=177 && n >= 154):
                    Console.WriteLine("Category 2 wow! ");
                    break;
                case int n when (n <= 209 && n >= 155):
                    Console.WriteLine("Category 3 RUN!!!");
                    break;
                case int n when (n <= 249 && n >= 156):
                    Console.WriteLine("Category 4 AHHHHHHHHH");
                    break;
                case int n when (n <= 250):
                    Console.WriteLine("AHHHHHHH HOW ARE YOU ALIVE");
                    break;
            }





        }
    }
}
