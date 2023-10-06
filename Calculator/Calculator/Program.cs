// See https://aka.ms/new-console-template for more information

using System;
public class Calulator
{
    public static void Main()
    {
        Console.Write("Enter First Number: ");
        int num1= Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter Second number: ");
        int num2= Convert.ToInt32(Console.ReadLine());
   
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
    }
}