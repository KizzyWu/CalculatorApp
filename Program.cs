using System;

class Program
{
    static void Main()
    {
        Console.Write("輸入第一個數字: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("輸入第二個數字: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("你輸入的是: " + a + " 和 " + b);
    }
}