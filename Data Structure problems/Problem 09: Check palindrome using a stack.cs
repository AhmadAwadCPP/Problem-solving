using System;
using System.Collections.Generic;


class clsIsPalindrome
{

    static bool IsPalindrome(string Input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char item in Input)
        {
            stack.Push(item);
        }

        foreach (char item in Input)
        {
            if (item != stack.Pop())
            {
                return false;
            }
        }

        return true;
    }


    static void Main()
    {
        Console.WriteLine(IsPalindrome("Ahmad"));

        Console.WriteLine(IsPalindrome("ASDFFDSA"));

        Console.ReadKey();
    }
}
