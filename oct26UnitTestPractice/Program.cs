using System;
using Xunit;
using Xunit.Sdk;

namespace oct26UnitTestPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter yes or no or y or n");

            string x = Console.ReadLine();

            bool y = IsYesOrNo(x);
            Console.WriteLine($"your input is {y}");
            //bool b = true;
           // Console.WriteLine(b.ToString());
        }
       
        
        public static bool IsYesOrNo(string str)
        {
            /*
             * Write a method called IsYesOrNo that will accept a string and return true if the string is 
             * “YES”, “Y”, “NO”, or “N”, in any casing, trimmed. Otherwise it will return false
             *
             */
           
            
            string input = str.Trim().ToUpper();

            if (input == "YES")
            {
                bool myBool = true;
                return myBool;
            }
            else if (input == "Y")
            {
                bool myBool = true;
                return myBool;
            }
            else if (input == "NO")
            {
                bool myBool = true;
                return myBool;
            }
            else if (input == "N")
            {
                bool myBool = true;
                return myBool;
            }
            else
            {
                return false;
            }
        }

    }
}
