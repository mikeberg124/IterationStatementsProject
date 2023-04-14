using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        

        static void Main(string[] args)
        {
          

            var numbers = new List<int>();

            int num = 1;

            do
            {
                num++;
                numbers.Add(num);


            } while (num < 100);
            








            while (num < 200) 
            {
                    num++;
                    numbers.Add(num);
               

            }



            Console.WriteLine("Increase");

                foreach (var item in numbers)
                {

                    Console.WriteLine(item);

                }





            Console.WriteLine("");
            Console.WriteLine("Decrease");
               
                

                for (int i = 199; i <= numbers.Count && i >= 0 ; i--) ;
                

                    Console.WriteLine($"{numbers[i]}");

               
           

           
        }
    }

 }


// Create a for loop - this will print the numbers in reverse order - from 200 to 1
// in your initializer set the value of i to 199
// in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
// AND as long as i is greater than or equal to 0
// Decrement i by 1

//start for loop here

// place numbers[i] inside of the Console.WriteLine() method
