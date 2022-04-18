// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace DotNetBasics;
class Method
{
    static void Main(string[] args)
    {
         int sum = Sum(4, 5);
         Console.WriteLine(sum);
    }


    static int Sum(params int[] values)
    {
        int result = 0;
        foreach(int value in values)
        {
            result = result + value;
        }
        return result;
    }
}