//C# Practice Project
//
//Build a calculator that can perform basic addition, subtraction, division and multiplication

using System;

namespace Calculator
{

    public class Calculator
    {
        public int a;
        public int b;

        public int Addition(int a, int b) 
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Divison(int a, int b)
        {
            return a / b;
        }
    }

}