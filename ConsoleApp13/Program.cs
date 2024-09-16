using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// This declares an integer array named numbers and initialies it with the vlaues 1to 10.

            
            Console.WriteLine("Array elements:");// this line prints a header indicating that the arrays elements will be displayed.
            foreach (int num in numbers)//this iterates over each element in the numbers array.
            {
                Console.Write($"{num} ");// this prints the current element followed by a space.
            }
            Console.WriteLine();

            
            int sum = 0;// declares varible an interger variable sum and initalizes it to 0.
            foreach (int num in numbers)// iterates over each element in the numbers array again.
            {
                sum += num;//adds current element to the sum variable.
            }
            Console.WriteLine($"Sum: {sum}"); // line prints the calculated sum.

           
            int max = numbers[0];// intiailizes the max variable with the first element of the array, assuming it's the maximum.
            int min = numbers[0];//intiailizes the min variable with the first element of the array, assuming it's the minimum.
            foreach (int num in numbers)//loop iterates over each element in the numbers array again.
            {
                if (num > max)//checks if the currents element is greater than the current max.
                {
                    max = num;// if the current element is greater, it updates the max variable with the new maximum value.
                }
                if (num < min)// checks if the current element is less than the current min.
                {
                    min = num;// current element is less it updates the min variable with the new minimum value.
                }
            }
            Console.WriteLine($"Maximum: {max}"); // prints the maximum value
            Console.WriteLine($"Minimum: {min}");// prints the minimum value

            Array.Reverse(numbers);// reverses the order of the elements in the numbers array
            Console.WriteLine("Reversed array:");// prints a header indicating that reversed array will be display.
            foreach (int num in numbers)//loop iterates over each element in the reveresed numbers array.
            {
                Console.Write($"{num} ");// line prints the current element followed by a space.
            }
        }
    }
}
