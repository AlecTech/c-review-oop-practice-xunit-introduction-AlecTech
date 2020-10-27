using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace oct26UnitTestPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter YES or NO or Y or N");

           // string x = Console.ReadLine();

           // bool y = IsYesOrNo(x);
           // Console.WriteLine($"your input is {y}");
          
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
        /*
         * Write assertions using Throws<FormatException>, 
         * Throws<IndexOutOfRangeException>, 
         * Throws<NullReferenceException> and 
         * Throws<DivideByZero Exception>, to demonstrate your 
         * understanding thereof. You can use built in C# methods.
         */
        public static void ThrowsFormatException()
        {
            int.Parse("Hello");
        }

        public static void ThrowsIndexOutOfRangeException()
        {
            List<Char> characters = new List<Char>();
            characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            for (int ctr = 0; ctr <= characters.Count; ctr++)
                Console.Write("'{0}'    ", characters[ctr]);
        }

        public static void ThrowsDivideByZero()
        {
            int y = 0;
            int x = 10/y;
        }

    }
}
