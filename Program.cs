// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// string? number = Console.ReadLine();

// if (number [0] == number [4] && number [1] == number [3])
// {
//     Console.WriteLine($"{number} - палиндром");
// }
// else Console.WriteLine($"{number} - не является палиндромом");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату точки А по Х: ");
// int АХ = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки А по Y: ");
// int АY = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки А по Z: ");
// int АZ = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки B по Х: ");
// int BХ = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки B по Y: ");
// int BY = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату точки А по Z: ");
// int BZ = Convert.ToInt32(Console.ReadLine());

// double legthAB = Math.Sqrt((Math.Pow(BХ-АХ,2) + Math.Pow(BY-АY,2) + Math.Pow(BZ-АZ,2)));
// Console.WriteLine($"Расстояние между точками А и В :{Math.Round(legthAB,2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите чисто N: ");
int N = Convert.ToInt32(Console.ReadLine());
// int start = 1;
for (int start = 1; start <= N; start++ )
{
    Console.WriteLine(Math.Pow(start,3));
}