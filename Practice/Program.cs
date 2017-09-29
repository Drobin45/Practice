using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem One. Create a method to see if a string is a palindrome or not. Complete!
            //string bill = "bill";
            //bool answer = CheckPal(bill);
            //Console.WriteLine(answer);

            //Problem Two. Given two numbers return the highest of the two numbers

            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //Console.WriteLine(GreaterNum(first, second));


            // Problem Three. Given an array of numbers, return the highest number in that array
            //Max() Method is a built in method that already returns the highest int in an array.

            //int[] numbers = { 5, 2, 3, 4, 1, 6 };
            //Console.WriteLine(GreatestNum(numbers));

            //Problem Four. Given an array of numbers, write a method that returns only even numbers

           // int[] numbers = { 1, 2, 3, 4, 5 };
           // Console.WriteLine(EvenNum(numbers));

           //Problem Five

        } //Method separation bracket ------------------------------------------------------

        //Problem Five Method


        //Problem Four Method

        //static int EvenNum(int[] numbers)
        //{                     
        //    int sum = 0;
        //    foreach (int i in numbers)
        //    {                
        //        if (i % 2 == 0)
        //        {
        //            sum += i;
        //        }                
        //    }
        //    return sum;
        //}

        //Advanced way of solving. Need to learn how 'select (int)i)' works
        // return (from i in numbers where i % 2 == 0 select (int)i).Sum();

        // Problem Three Method

        //public static int GreatestNum(int[] numbers)
        //{
        //    int max = 0;
        //    foreach (int value in numbers)
        //    {

        //        if (value > max)
        //        {
        //            max = value;
        //            continue;
        //        }
        //        if (value < max)
        //        {
        //            continue;
        //        }
        //    }
        //    return max;
        //}

        //------------------------------------------------------

        //Problem Two Method

        //public static int GreaterNum(int first, int second)
        //{
        //    if (first > second)
        //    {
        //        return first;
        //    }
        //    else
        //    {
        //        return second;
        //    }
        //}

        //--------------------------------------------------------------------------

        //Problem one method
        //public static bool CheckPal(string inputString)
        //{
        //    inputString.Split();
        //    if (inputString.Reverse() == inputString)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }       

    }

}

