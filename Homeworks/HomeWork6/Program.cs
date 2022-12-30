// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Укажите сколько чисел Вы хотите ввести");  
//             int n = Convert.ToInt32( Console.ReadLine() );
//             int count = 0;
//             for (int i=0;i<n;i++)
//             {
//                 Console.WriteLine("Вводите числа: "); 
//                 int a = Convert.ToInt32( Console.ReadLine() );
//                 if (a>0) count = count + 1;
//             }
//             Console.WriteLine("Количество чисел больше 0 которые ввёл пользователь = {0}", count);
//             Console.ReadKey();




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Координаты b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты k2:");
double k2 = Convert.ToInt32(Console.ReadLine());



double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точками пересечения двух прямых заданных Вами координат является X: {x}, Y: {y}");


