﻿using StringManipulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Exercise 1
             * 1. Ask from the user 6 integers, e.g. 1,2,3,4,5,6
             * 2. Generate from each number a random number with limit up to this number
             *    e.g. -4, 0, 1, 3, 2, 5  
             * 3. Place these 6 random numbers to a list
             * 4. Rearrange the list so the numbers are places ascending
             * 5. Rearrange the list so the numbers are places descending
             * 6. Show the sum of all the numbers
             */

            /* Exercise 2
             * 1. Use the previous list of random numbers and generate a list of random strings, e.g.
             *    if the list contains the number 4 then 
             *    you should generate a random string with 4 characters
             * 2. Search on every string and display the number of occurences each char occurs
             *    e.g. "keiwe", k:1, e:2, i:1, w:1
             * 3. Show from all of the strings inside the list the top 3 chars that have the most
             *    occurences
             */

            Exercise1 exercise1 = new Exercise1();
            Exercise2 exercise2 = new Exercise2();
        }
    }
}
