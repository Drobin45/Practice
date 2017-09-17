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
// Problem One. Create a method to see if a string is a palindrome or not. Incomplete
            string bill = "bill";
            bool answer = CheckPal(bill);
            Console.WriteLine(answer);


            

        } //Method separation bracket

        public static bool CheckPal(string inputString)
        {
            inputString.Split();
            if (inputString.Reverse() == inputString)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
