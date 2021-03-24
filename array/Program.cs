using System;
using System.Collections.Generic;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();   
            Exercise2();   
            Exercise3();   
            Exercise4();   
            Exercise5();   
        }

        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.
        public static void Exercise1()
        {
           var names = new List<string>();

           while (true)
           {
               Console.WriteLine($"Enter name (or hit Enter to quit): ");
               var input = Console.ReadLine();

               if(String.IsNullOrWhiteSpace(input)) break;
               names.Add(input);
           }

           if(names.Count > 2)
                // Console.WriteLine(names[0] + ", " + names[1] + " and " + names.Count-2 + " others like your post");
                Console.WriteLine($"{0}, {1} and {2} other like your post", names[0],names[1],names.Count - 1);
            else if(names.Count == 2) 
                // Console.WriteLine(names[0] + ", " + names[1] + " like your post");
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if(names.Count == 1) 
                // Console.WriteLine(names[0] + " like your post");
                Console.WriteLine("{0} likes your post.", names[0]);
            else 
                Console.WriteLine();
        }

        //2- Write a program and ask the user to enter their name. 
        //Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.

        // Solution 1 use List
        public static void Exercise2()
        {
            Console.WriteLine($"Enter your name: ");
            var input = Console.ReadLine();

            var name = new List<char>();
            name.AddRange(input);
            
            var reverseName = "";
            for(var i=name.Count-1;i>=0;i--)
                reverseName += name[i];

            Console.WriteLine($"Reverse Name: " + reverseName);
        }

        // Solution 2 use array
        // public static void Exercise2()
        // {
        //     Console.WriteLine($"Enter your name: ");
        //     var name = Console.ReadLine();

        //     var array = new char[name.Length];
        //     for(var i=0;i<name.Length;i++)
        //         array[array.Length - 1- i] = name[i];

        //     var reverseName = new string(array);
        //     Console.WriteLine(reverseName);
        // }

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        public static void Exercise3()
        {
            var numbers = new List<int>();
            while(numbers.Count < 5){
               Console.WriteLine($"Enter your number: ");
               var number = Convert.ToInt32(Console.ReadLine());
               if(numbers.Contains(number)){
                    Console.WriteLine("You've previously entered " + number);
                    continue;
               }

               numbers.Add(number);
           }

           numbers.Sort();

           foreach(var number in numbers)
                Console.WriteLine(number + " ");   
        }

        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>

        public static void Exercise4()
        {
            var numbers = new List<int>();
            while(true){
                Console.WriteLine($"Enter a number (or hit Quit to exit): ");
                var input = Console.ReadLine();

                if(input.ToLower() == "quit") break;

                numbers.Add(Convert.ToInt32(input));
            }

            //SOLUTION 1
            for(var i=0;i<numbers.Count;i++)
            {
                var current = numbers[i];
                int count=0;
                for(var j=0;j<numbers.Count;j++)
                    if(numbers[j] == current) count++;
                
                if(count < 2) 
                {
                    Console.WriteLine("Unique numbers:");
                    Console.Write(current + " ");
                };
            }

            //SOLUTION 2
            // var uniques = new List<int>();

            // foreach(var number in numbers)
            //     if(!uniques.Contains(number))
            //         uniques.Add(number);

            // Console.WriteLine("Unique numbers: ");
            // foreach(var number in uniques)
            //     Console.Write(number + " ");
        }

        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// </summary>
        public static void Exercise5()
        {
            var elements = new List<string>();
            while(true)
            {
                Console.WriteLine($"Enter a list of comma separated numbers: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input)){
                    elements.AddRange(input.Split(','));
                    if(elements.Count >= 5) break;
                }
                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach(var element in elements)
                numbers.Add(Convert.ToInt32(element));
            
            var smallestNumbers = new List<int>();
            while(smallestNumbers.Count < 3){
                var min= numbers[0];
                foreach(var number in numbers)
                    if(number < min) min=number;

                smallestNumbers.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallestNumbers)
                Console.WriteLine(number);
        }
    }
}
