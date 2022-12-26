// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// int MaxNumber (int num) //27
// {
//     int a = num/10;
//     int b = num%10;
//     if(a>b);
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// int randomNumber = new Random().Next(10,99+1);
// Console.WriteLine(randomNumber);
// int result = MaxNumber(randomNumber);
// Console.WriteLine(result);


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int DeleteNumber(int num) // 456
// {
//     int sot = num / 100;
//     int ed = % 10;
//     return sot*10 + ed;

// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);

// int DeleteNumber (int num)// 456
// {
//     int sot = num / 100 ;
//     int ed  = num % 10;
//     return sot*10 + ed;

// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если второе число не кратно числу первому, то программа 
// выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


// void kratnost(int num1, int num2)
// {
//     if(num2%num1 == 0)
//     {
//     Console.WriteLine($"{num1}, {num2}-> кратно" );
//     }

//     else
//     Console.WriteLine($"{num1}, {num2}-> не кратно, {num2%num1}" );
// }
// Console.WriteLine ("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine ("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine ());
// kratnost (num1,num2);



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// // 14  ->  нет
// // 46  ->  нет
// // 161 ->  да

// bool kratnost(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     return false;
// }

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = kratnost(num);
// Console.WriteLine(result);


