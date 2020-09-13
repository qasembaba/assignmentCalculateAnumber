using System;
using System.Runtime.InteropServices;

namespace assignmentCalculateAnumber
{
    class Program
    {
        // declaring a method
        static void CompereNumbers ()

        {
            int numberOne;
            int numberTwo;

            Console.WriteLine("Please enter a number: ");
            numberOne = TextToNumber(Console.ReadLine());

            Console.WriteLine("Please enter a number: ");
            numberTwo = TextToNumber(Console.ReadLine()); 

            if (numberOne > numberTwo )
            {
                Console.WriteLine("First number is the biggest");

            }
            else
            { 
                Console.WriteLine("Second number is the biggest");
            
            }



        }
        static int TextToNumber (string textNumber)
        {
            int number = 0;
            int.TryParse(textNumber, out number);
            return number;

        }

       
    }  

}
