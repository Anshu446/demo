using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_number
{
        class Program
        {
            static void Main(string[] args)
            {
                int a = 121; int b; int result = 0; int temp = a;

                while (a != 0) { b = a % 10; result = result * 10 + b; a = a / 10; }

                a = temp;

               
            if (a == result)
              {
                Console.WriteLine("Palindrome Number");
              } 
            else 
            {
                Console.WriteLine("Not a palindrome Numbber");
            }
                Console.ReadLine();
            }
        }
    }


