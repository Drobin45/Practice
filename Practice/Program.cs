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

            //Problem Five. Create an empty array that the user types in. Sum the total of this array without Sum().
            //int[] numbers = new int[6];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Please enter a single interger");
            //    i = int.Parse(Console.ReadLine());                
            //}

            //Console.WriteLine(Total(numbers));

            //Problem Six. Given an array, create a method that will reverse the array

            int[] number = {1, 2, 3, 4};

                //Using Array.Reverse to reverse the int[]
            //foreach(int value in number)
            //{
            //    Console.WriteLine(value);
            //}
            //Array.Reverse(number);

            //foreach (int value in number)
            //{
            //    Console.WriteLine(value);
            //}
            foreach(int value in number)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine(Invert(number));

            foreach (int value in number)
            {
                Console.WriteLine(value);
            }


            //Test for ReverseString Method
            // Console.WriteLine(ReverseString("framework"));


        } //Method separation bracket ------------------------------------------------------

        //Problem Six Method

        //Method for reversing a string
        //public static string ReverseString(string s)
        //{
        //    char[] arr = s.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}

        public static int[] Invert(int[] number)
        {
            for (int i = 0; i < number.Length % 2; i++)
            {
                //for(int j = number.Length; j > number.Length % 2; j--)
                //{
                //    number[j] = number[i];
                //}  
                int tmp = number[i];
                number[i] = number[number.Length - i - 1];
                number[number.Length - i - 1] = tmp;
            }
            return number;
        }

        //Problem Five Method
        //static int Total(int[] numbers)
        //{
        //    int sum = 0;
        //    foreach(int i in numbers)
        //    {                
        //            sum += i;                
        //    }
        //    return sum;
        //}

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

