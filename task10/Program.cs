// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console. Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumOfDigits(int number) {
do
{
    sum = sum + number % 10;
    number /= 10;
} while (number > 0);
return sum;
}
int summ = SumOfDigits(number);

Console.WriteLine($"Sum of digits in the number: {summ}");