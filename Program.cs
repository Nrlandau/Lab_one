/*This program takes two integers with the same number of digits and compairs if the added digits of each number is the same.
This program cannot take non integer inputs.
Examples
***
1   2   3   4
4   3   2   1
5 = 5 = 5 = 5

True
***

1   2   3   5
4   3   2   1
5 = 5 = 5 !=6
False
***
 */


using System;

namespace Project_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int number1, number2;
            int length1, length2;
            int [] digitAdd;
            //User Input
            System.Console.WriteLine("Input an integer number:");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input a second integer number with the same number of digits as the first:");
            number2 = int.Parse(System.Console.ReadLine());
            
            length1 = GetLength(number1);
            length2 = GetLength(number2);
            //handles negitive numbers. Without this inputs 1234 and -1234 turns true.
            if(length1 == -1)
            {
                number1 *= -1;
            }

            if(length2 == -1)
            {
                number2 *= -1;
            }
            //input cleansing
            if(length1 != length2 && !(length1 == 1 && length2 ==0 || length1 == 0 && length2 == 1))
            {
                System.Console.WriteLine("ERROR: The numbers are not the same length.");
                return;
            }

            // logic

            digitAdd = new int[length1];
            for(int i = 0; i < length1; i++)
            {
                digitAdd[i] = GetDigit(i,number1) + GetDigit(i,number2);
                //System.Console.WriteLine("{0} = {1} + {2}",digitAdd[i], GetDigit(i,number1),  GetDigit(i,number2));
            }

            //print statment
            for(int i =1; i < length1; i++) 
            {
                if(digitAdd[i] !=digitAdd[0])
                {
                    System.Console.WriteLine("False");
                    return;
                }
            }
            System.Console.WriteLine("True");
        }
        static int GetLength(int num) // Returns the number of digits in a integer.
        {
            bool isZero = false;
            int length = 0;
            while(!isZero)
            {
                if(num == 0)
                {
                    isZero = true;
                    continue;
                }
                num = num / 10;
                length++;
            }
            return length;
        }

        static int GetDigit(int digit, int num) // Returns the nth Digit.
        { 
            for(int i = 0; i < digit; i++)
            {
                num /= 10;
            }
            num %= 10;
            return num;
        }
    }
}