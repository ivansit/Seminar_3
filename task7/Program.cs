// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 1;
while (N > 1) {result *= N;N--;}
Console.WriteLine($"Факториал равен {result}");

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int result = 1;

// for (int i = 1; i <= A; i++)
// {
//     Console.WriteLine($"i = {i}");
//     result = result * i;
// }
// Console.WriteLine($"Результат выполнения программы = {result}");