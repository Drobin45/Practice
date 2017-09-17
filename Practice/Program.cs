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
            string bill = "bill";
            bool answer = CheckPal(bill);
            //Console.WriteLine(answer);

            // Problem Two. Given an array of numbers, return the highest number in that array
            int[] blue = { 1, 2, 3, 4, 5, 6 };
            int highNum = GreatestNum(blue);
            Console.WriteLine(highNum);



        } //Method separation bracket

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

        //Problem two method

        public static int GreatestNum(int[] numbers)
        {
            for (int i = 0; i >= numbers.Length; i++)
                if (numbers(i) > numbers(i + 1))
                    {
                    continue;
                    }
                else if (numbers(i) = numbers.Length)
                {
                    return numbers(i);
                }
        }

    }

}
}
