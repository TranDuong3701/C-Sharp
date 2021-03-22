using System;

namespace control_flow
{
    class Program
    {

        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        static void Exercise1()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number >=1 && number <= 10)
                Console.WriteLine("Valid!");
            else 
                Console.WriteLine("Invalid!");
                
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        static void Exercise2()
        {
            Console.WriteLine("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2) 
                Console.WriteLine(number1);
            else 
                Console.WriteLine(number2);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        static void Exercise3()
        {
            Console.WriteLine($"Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter height");
            int height = Convert.ToInt32(Console.ReadLine());

            var result = width > height ? TypeOfImage.Landscape : TypeOfImage.Portrait;
            Console.WriteLine(result);
        }

        public enum TypeOfImage{
            Landscape,
            Portrait
        }


        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        static void Exercise4()
        {
            Console.WriteLine($"Enter limit speed: ");
            var limitSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter speed of a car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed < limitSpeed) 
                Console.WriteLine($"OK");
            else
            {
                const int kmDemeritPoints = 5;
                var demeritPoints = (carSpeed - limitSpeed) / kmDemeritPoints;
                if(demeritPoints > 12)
                    Console.WriteLine($"License Suspended");
                else
                    Console.WriteLine(demeritPoints);
                    
                    
            }   
            
        }

        static void Main(string[] args)
        {
            
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }

    }
}
