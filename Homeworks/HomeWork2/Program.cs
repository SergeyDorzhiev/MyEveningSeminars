// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int DeleteNumber(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return (num - (sot*100) - ed)/10;

// }
// Console.WriteLine("Введите трехзначное число");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = DeleteNumber(N);
// Console.WriteLine(result);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введи любое число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи число от 1 до 7: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 5){
  Console.WriteLine($"{Number} -> да");
}
else {
  Console.WriteLine($"{Number} -> нет");
}
