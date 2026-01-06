using System;

class Calculator

{
    public static int number = 1013; public static int number2 = 1013;
    public static int Add()
    {return number + number2;}

    public static void Main(string[] args)
    {int result = Add(); Console.WriteLine("the sum is: " +result);}
}