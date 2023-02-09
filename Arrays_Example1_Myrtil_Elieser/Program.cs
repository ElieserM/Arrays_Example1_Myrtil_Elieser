using System;
using System.Linq;

namespace My_Application
{
     class Program
    {
        static void Main(string[] args)
        {
           /*
            * You can store variable of the same data type
            * Declaring an array by specifying the type of elements
            * The variables are ordered and has an index beginning from 0
            * C# array are objects of base type System
            */

            //Declare a single-dimensional array
            //[5] is the length of the array
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[5] {6, 7, 8, 9, 10};

            //Create an arrays of strings
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            cars[0] = "Kia";
            Console.WriteLine(cars[0]);

            //Declare a multi dimensional array
            //0 is the first set and the 1 is the sequence of the first set starting from the sequence of 0
            int[,,] multiDimensionalArray = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 1, 2, 3 }, { 4, 5, 6 } } };
            multiDimensionalArray[0, 0, 0] = 5;
            Console.WriteLine(multiDimensionalArray[1,1,1]);

            //Property
            int len = numbers.Length;
            int Dim = multiDimensionalArray.Rank;

            Console.WriteLine("number's length is: " + len.ToString());
            Console.WriteLine("multiDimensionalArray dimensions are: " + Dim.ToString());

            //Loop
            Console.WriteLine("For Loop");
            for (int i = 0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("Foreach");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int idx = 0;
            foreach (int number in numbers)
            {
                numbers[idx] = 2 * number + 1;
                Console.WriteLine(numbers[idx]);
                idx++;
            }
            //Sort an array
            Console.WriteLine("");
            Console.WriteLine("Sorting");
            int[] myNumbers = { 5, 2, 8, 9 };
            

            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("The max value in myNumbers is " + myNumbers.Max().ToString());
            Console.WriteLine("The sum value in myNumbers is " + myNumbers.Sum().ToString());
        }
    }
}