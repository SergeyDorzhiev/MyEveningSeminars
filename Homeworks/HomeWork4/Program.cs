// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Sum(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

// Console.Write("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Б: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int sum = Sum(numberA, numberB);
// Console.WriteLine("Ответ: " + sum);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write("Введите число произвольное число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int Sum(int numberN){
    
// int count = Convert.ToString(numberN).Length;
// int advance = 0;
// int result = 0;

// for (int i = 0; i < count; i++)
// {
//     advance = numberN - numberN % 10;
//     result = result + (numberN - advance);
//     numberN = numberN / 10;
// }
// return result;
// }

// int sum = Sum(numberN);

// Console.WriteLine("Ответ: " + sum);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
int[] myArray = new int[size];
for(int i=0;i<size;i++)
{
myArray[i] = new Random().Next(minValue,maxValue+1);
}
return myArray;
}

void ShowArray (int[] array)
{
Console.WriteLine("Полученный массив ->:");
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+" ");
}
Console.WriteLine();
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght,min,max);
ShowArray(newArray);