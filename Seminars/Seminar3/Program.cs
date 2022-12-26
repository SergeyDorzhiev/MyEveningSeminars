// // Задача 4. Напишите программу которая принимает на вход число (N) и выдает

// /* void N(int number)
// {
    
//     for (int i = 1; i < number; i++)
//     {
//             Console.WriteLine (i*i);
//     }
// }

// Console.WriteLine("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// N(x); */

// Pflfxf 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// int N (double x1, double y1, double x2, double y2)
// {
//     double k1 = x1 - x2;
//     double k2 = y1 - y2;
//     doubre g = Math.Sqrt(k1*k1+k2*k2);
//     double k1 = x1 - x2;

//     return g;
// }
// Console.WriteLine(Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double result = N(x1, y1, x2, y2);
// Cansole.WriteLine(result);
// // A (3, )
// // 
double N (double x1, double y1, double x2, double y2)
{
    double k1 = x1 - x2;
    double k2 = y1 - y2; 
    double g =Math.Round(Math.Sqrt(k1*k1+k2*k2),2);
 
return g ;
}
Console.WriteLine("Координаты x1:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y1:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты x2:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты y2:");
double y2 = Convert.ToInt32(Console.ReadLine());

double result = N(x1, y1, x2, y2);
Console.WriteLine(result);
