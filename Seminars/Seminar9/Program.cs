//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNum (int num)
// {
//     if(num>=1)
//     {
//         PrintNum(num-1);
//         Console.Write(num+" ");
//     }
// }

// PrintNum(100);





//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum (int num)
// {
//     if(num>0)
//     {
//         return FindSum(num/10) + num % 10;
//     }
//     else 
//     return num;
// }

// int result = FindSum(999);
// Console.WriteLine(result);




//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void PrintNUm ( int m, int n)
// {
//    if (m!=n)
//    {
//     if(m>n)
//     {
//     PrintNUm(m-1,n);
//     Console.Write(m + " ");
//     }
//     else if (n>m)
//     {
//     PrintNUm(m,n-1);
//     Console.Write(n + " ");
//     }   
//     }
//     else Console.Write(m+" ");
// }
// PrintNUm(2,5);





//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int Stepen (int a, int b)
// {
//     if (b != 0)
//     return a = a * Stepen(a, b-1);
//     else return 1;
// }

// int result = Stepen (2, 3);
// Console.WriteLine(result);

int FindSum ( int a, int b)
{
    if(b != 0)
    {
      return FindSum(a, b -1) * a;
    }
    else return 1;
}
int result = FindSum(100,3);
Console.WriteLine(result);
