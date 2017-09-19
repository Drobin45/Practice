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

            //Problem Two

            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //Console.WriteLine(GreaterNum(first, second));


            // Problem Three. Given an array of numbers, return the highest number in that array
            int[] numbers = { 5, 2, 3, 4, 1, 6 };
            //int highNum = blue.Max();              
            int highNum = GreatestNum(numbers);
            Console.WriteLine(highNum);



        } //Method separation bracket ------------------------------------------------------

        //Problem Three Method

        public static int GreatestNum(int[] numbers)
        {
            int max = 0;
            for (int i = 0; i >= numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                   continue;
                }
                if (numbers[i] < max)
                {
                    continue;
                }                    
            }
            return max;

            //if (numbers(i) > numbers(i + 1))
            //{
            //    continue;
            //}
            //else if (numbers(i) = numbers.Length)
            //{
            //    return numbers(i);
            //}
        }

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

