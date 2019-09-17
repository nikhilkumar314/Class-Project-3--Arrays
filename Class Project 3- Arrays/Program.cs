/* 
Author: Nikhil Kumar
Date: September 17, 2019
Description: Arrays 
*/

using System;

namespace Class_Project_3__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // An array with 25 elements in it
            int[] Array = new int[25];

            // Iterate through the array with a Foreach Loop
            for (int i = 0; i < 26; i++)
            { 
                //Console writes out some information to the user and displays each iteration of the element in the array
                Console.WriteLine("Element value = " + i);
                Console.WriteLine("Iterating through the array..." + "\n" + "Next element loading...");
            }
        }
    }
}

