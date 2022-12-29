// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
// int[] myArray = new int[size];
// for(int i=0;i<size;i++)
// {
// myArray[i] = new Random().Next(minValue,maxValue+1);
// }
// return myArray;
// }

// void ShowArray (int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// void EvenNumbers (int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) count = count + 1;
//         else
//         count = count;
//     }
//     Console.WriteLine($"Количество чётных чисел в массиве {count}");
// }

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// EvenNumbers(newArray);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
// int[] myArray = new int[size];
// for(int i=0;i<size;i++)
// {
// myArray[i] = new Random().Next(minValue,maxValue+1);
// }
// return myArray;
// }

// void ShowArray (int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());


// void  Sumodd (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 1) sum = sum + array[i];
// //      if(i % 2 == 1) sum = 0;
//     }
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sum}");
// }

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// Sumodd(newArray);







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

void MinMax (int[] array)
{
    int Maxin = array [0];
    int Minin = array [0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < Maxin) Maxin = array[i];
        if(array[i] > Minin) Minin = array[i];
    }
    Console.WriteLine($"Min равен {Maxin}, Max равен {Minin}, разницу между максимальным и минимальным элементов массива составляет {Minin - Maxin}");
    int lenght = Convert.ToInt32(Console.ReadLine());
}

int[] newArray = CreateRandomArray(lenght,min,max);

ShowArray(newArray);
MinMax(newArray);