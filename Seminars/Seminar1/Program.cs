// Console.WriteLine("Input Number");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = x * x;
// Console.WriteLine($"Quad of your number is {x} -> {y} ");



// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет
// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());
//
// int quad = b * b;
//
// if(quad ==a)
//{
//    Console.WriteLine($"{a} IServiceProvider quad of {b}");
//}
//else
//{
//    Console.WriteLine($"{a} is not quad of {b}");
//}
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Input Number");
int N = Convert.ToInt32 (Console.ReadLine());

if (N > 0)
{
   N = N * (-1);
}
int t = N * (-1);
while(N <= t)
{
   Console.WriteLine($"{N}");
   N ++;
}

//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
//    456 -> 6
    
//    782 -> 2
    
//    918 -> 8

// Console.WriteLine("Input Number");
// int N = Convert.ToInt32 (Console.ReadLine());
// int R = N % 10;

// Console.WriteLine($"{R}");