using System;
using System.Text;

/* This program will Display the calculation from two values. Two inputs will be prompted*/


namespace Excercise;


class Calculator
{

    public static void Main(String[] args)
    {

        //Declaring variables
        int num1, num2;
        int totalsum;

        Console.WriteLine("Please enter the first number"); //prompts user to enter the first number.
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the second number"); //prompts user to enter the second number.
        num2 = Convert.ToInt32(Console.ReadLine());

        totalsum = num1 + num2;

        Console.WriteLine("The sum between the two numbers " + totalsum);
        Console.ReadKey();


    }



}
