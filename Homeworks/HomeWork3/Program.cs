// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine();
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - является палиндром.");
//   }
//   else {
//     Console.WriteLine($"Ваше число: {number} - не является палиндром.");
// }




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double N (double x1, double y1, double c1, double x2, double y2, double c2)
{
    double k1 = x1 - x2;
    double k2 = y1 - y2;
    double k3 = c1 - c2;
    double g = Math.Round(Math.Sqrt(k1*k1+k2*k2+k3*k3),2);
    
    return g;
}
Console.WriteLine("Координаты x1:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y1:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты c1:");
double c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты x2:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y2:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты c2:");
double c2 = Convert.ToInt32(Console.ReadLine());

double result = N(x1, y1, c1, x2, y2, c2);
Console.WriteLine(result);




// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
// от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void N(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         Console.WriteLine(i*i*i);
//     }
// }
// Console.WriteLine("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// N(x);