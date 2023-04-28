// See https://aka.ms/new-console-template for more information


using System;

 

public class Program
{
    public static void Main()
    {
        string str1 = "hello";
        string str2 = "ollei";

 

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Strings are not reverse of each other");
            return;
        }

 

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[str2.Length - 1 - i])
            {
                Console.WriteLine("Strings are not reverse of each other");
                return;
            }
        }

 

        Console.WriteLine("Strings are reverse of each other");
    }
}